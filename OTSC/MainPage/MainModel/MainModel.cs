using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accessibility;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace OTSC.MainPage.MainModel
{
    public class MainModel
    {
        public async Task<DataTable> GetFriedns(long id)
        {
            var connect = new DataBase.DataReader(@"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            string query = "SELECT friend_username,date_of_birth,interested FROM friend_list WHERE telegram_id=@id";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connect.СonnectionString))
                {
                    await connection.OpenAsync();

                    // Создаем команду и добавляем параметр
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        // Используем DataAdapter с командой
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки");
                return null;
            }
        }

        public async Task<bool> AddFriendAsync(long id, string username, DateTime dateTime, string interest)
        {
            var connect = new DataBase.DataReader(@"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            try
            {
                await using var connection = new NpgsqlConnection(connect.СonnectionString);
                await connection.OpenAsync();
                string query = "SELECT COUNT(*) FROM friend_list WHERE friend_username = @username";
                await using var command=new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                var result = await command.ExecuteScalarAsync();
                if (result != null && Convert.ToInt64(result) > 0) // Проверяем количество
                {
                    MessageBox.Show("Пользователь с этим username уже добавлен", "Ошибка добавления");
                    return false;
                }
                string query_add = "INSERT INTO friend_list(telegram_id,friend_username,date_of_birth,interested) VALUES(@id,@username,@dateTime,@interest)";
                await using var command_add=new NpgsqlCommand(query_add, connection);
                command_add.Parameters.AddWithValue("@id",id);
                command_add.Parameters.AddWithValue("@username",username);
                command_add.Parameters.AddWithValue("dateTime",dateTime);
                command_add.Parameters.AddWithValue("interest",interest);
                command_add.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить данные в Бд",ex.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }


        public async Task<bool> DeleteFriendAsync(long id, string username)
        {
            var connect = new DataBase.DataReader(@"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            try
            {
                await using var connection = new NpgsqlConnection(connect.СonnectionString);
                await connection.OpenAsync();
                string query = "DELETE FROM friend_list WHERE friend_username=@username";
                await using var command_add = new NpgsqlCommand(query, connection);
                command_add.Parameters.AddWithValue("@username", username);
                command_add.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить данные в Бд", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public async Task<bool> UpdateFriendAsync(long id, string username, DateTime dateTime, string interest,string choose)
        {
            var connect = new DataBase.DataReader(@"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            try
            {
                await using var connection = new NpgsqlConnection(connect.СonnectionString);
                await connection.OpenAsync();
                string query = "SELECT COUNT(*) FROM friend_list WHERE friend_username = @username";
                await using var command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                var result = await command.ExecuteScalarAsync();
                if (!(result != null && Convert.ToInt64(result) > 0)) // Проверяем количество
                {
                   await AddFriendAsync(id, username, dateTime, interest);
                   await DeleteFriendAsync(id,choose);
                    return true;
                }
                string query_update = "Update friend_list SET date_of_birth=@dateTime, interested=@interest WHERE friend_username=@username";
                await using var command_add = new NpgsqlCommand(query_update, connection);
                command_add.Parameters.AddWithValue("@id", id);
                command_add.Parameters.AddWithValue("@username", username);
                command_add.Parameters.AddWithValue("dateTime", dateTime);
                command_add.Parameters.AddWithValue("interest", interest);
                command_add.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось добавить данные в Бд", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
