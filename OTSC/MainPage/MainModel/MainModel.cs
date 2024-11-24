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
            string query = "SELECT friend_username, date_of_birth, interested FROM friend_list WHERE telegram_id = @id";
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
    }
}
