using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC.ProfilePage.ProfileModel
{
    public class ProfileModel
    {
        public async Task<bool> IsSend(long id, string mail)
        {
            var connect = new DataBase.DataReader(@"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            try
            {
                await using var connection = new NpgsqlConnection(connect.СonnectionString);
                await connection.OpenAsync();
                string query = "UPDATE users SET mail=@mail WHERE telegram_id=@id";
                await using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("mail", mail);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Не удалось отправить данные");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Нет соединения с БД");
                return false;
            }
        }
        public async Task<bool> RewritePass(long id,string first,string second)
        {
            var connect= new DataBase.DataReader(@"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            try
            {
                await using var connection = new NpgsqlConnection(connect.СonnectionString);
                await connection.OpenAsync();
                string query = "SELECT password FROM users WHERE telegram_id=@id";
                await using var command = new NpgsqlCommand(query,connection);
                command.Parameters.AddWithValue("@id", id);
                var oldPsw=await command.ExecuteScalarAsync() as string;
                if (oldPsw !=first)
                {
                    MessageBox.Show("Вы ввели неверный пароль", "Ошибка");
                    return false;
                }
                string update = "UPDATE users SET password=@pas WHERE telegram_id=@id";
                await using var updatePsw=new NpgsqlCommand(update,connection);
                updatePsw.Parameters.AddWithValue("@pas", second);
                updatePsw.Parameters.AddWithValue("@id", id);
                var newpas= await updatePsw.ExecuteScalarAsync();
                
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
