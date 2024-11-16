using Npgsql;
using OTSC.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
    }
}
