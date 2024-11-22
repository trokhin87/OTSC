using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace OTSC.MainPage.MainModel
{
    public class MainModel
    {
        public async Task <bool> IsSend(long id,string mail)
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
                int rowsAffected=command.ExecuteNonQuery();
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
    }
}
