using Npgsql;
using OTSC.DataBase;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace OTSC.LoginPage.LoginModel
{
    public class LoginModel
    {
        private string _connection;
        public LoginModel(DataReader data, string filePath)
        {

            _connection = data.СonnectionString;
        }
        public async Task<bool> CheckAndOpenConnectionLoginAsync(string id, string password)
        {
            try
            {
                await using var connection = new NpgsqlConnection(_connection);
                await connection.OpenAsync();
                long login = long.Parse(id);
                string query = "SELECT COUNT(1) FROM users WHERE telegram_id = @login AND password = @password";
                await using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("login", login);
                command.Parameters.AddWithValue("password", password);
                var result = await command.ExecuteScalarAsync();
                if (Convert.ToInt32(result) > 0)
                {
                    MessageBox.Show("Вход успешно выполнен", "Доступ получен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Такого пользователя не существует или введен неверный пароль или логин", "Неверные данные для входа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка с соединением к базе данных", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<bool> CheckAndOpenRegisterAsync(string id, string password)
        {
            try
            {
                await using var connection = new NpgsqlConnection(_connection);
                await connection.OpenAsync();
                long login = long.Parse(id);
                // Проверка на существование пользователя
                string checkQuery = "SELECT COUNT(1) FROM users WHERE telegram_id = @telegramId";
                await using (var checkCommand = new NpgsqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("telegramId", login);
                    var exists = await checkCommand.ExecuteScalarAsync();

                    if (Convert.ToInt32(exists) > 0)
                    {
                        MessageBox.Show("Пользователь с таким ID уже существует.", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                string insertQuery = "INSERT INTO users (telegram_id, password) VALUES (@telegramId, @password)";
                await using (var insertCommand = new NpgsqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("telegramId", login);
                    insertCommand.Parameters.AddWithValue("password", password);

                    // Выполняем вставку данных
                    int rowsAffected = await insertCommand.ExecuteNonQueryAsync();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при добавлении пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка с соединением к базе данных", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        //отправка письма на почту нового пароля
        public async Task SendEmailAsync(string mail,string generatorPass)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.Credentials = new NetworkCredential("trokhin87@gmail.com", "ijwv letp hftu azij");
                smtpClient.EnableSsl = true;
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From=new MailAddress("trokhin87@gmail.com");
                    mailMessage.To.Add(mail);
                    mailMessage.Subject = "Change password";
                    mailMessage.Body = generatorPass;


                    await smtpClient.SendMailAsync(mailMessage);
                }
            }
        }



        //поиск почты по логину
        public async Task<string> FindMailAsync(string login)
        {
            string query = "SELECT mail FROM users WHERE telegram_id=@telegram_id";
            try
            {
                await using var connection = new NpgsqlConnection(_connection);
                await connection.OpenAsync();
                long id = long.Parse(login);
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@telegram_id", id);
                    var result= await command.ExecuteScalarAsync();
                    return result?.ToString() ?? string.Empty;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Вы не ввели свою почту в профиле", "Восстановить аккаунт не имеется возможности");
                return string.Empty;
            }
        }




        //Генерация обновленного пароля
        public string GeneratorPassword()
        {
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*()_-+=<>?";
            string allChars = upperChars + lowerChars + digits + specialChars;

            // Генератор случайных чисел
            Random random = new Random();

            // Строим пароль
            StringBuilder password = new StringBuilder();

            // Гарантируем наличие хотя бы одного символа из каждой категории
            password.Append(upperChars[random.Next(upperChars.Length)]);
            password.Append(lowerChars[random.Next(lowerChars.Length)]);
            password.Append(digits[random.Next(digits.Length)]);
            password.Append(specialChars[random.Next(specialChars.Length)]);

            // Заполняем оставшиеся символы случайным образом
            for (int i = 4; i < 20; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            // Перемешиваем пароль
            return Shuffle(password.ToString());
        }
        private string Shuffle(string input)
        {
            char[] array = input.ToCharArray();
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (array[i], array[j]) = (array[j], array[i]); // Перемешиваем элементы
            }
            return new string(array);
        }





        //Обновление пароля в БД
        public async Task<bool> UpdatePasswordAsync(string login, string password)
        {
            long id=long.Parse(login);
            try
            {
                await using var connection = new NpgsqlConnection(_connection);
                await connection.OpenAsync();
                string update = "UPDATE users SET password=@pas WHERE telegram_id=@id";
                await using var updatePsw = new NpgsqlCommand(update, connection);
                updatePsw.Parameters.AddWithValue("@pas", password);
                updatePsw.Parameters.AddWithValue("@id", id);
                var newpas = await updatePsw.ExecuteScalarAsync();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с БД");
                return false;
            }
        }
    }
}
