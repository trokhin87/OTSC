using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace OTSC.MainPage.MainModel
{
    public class MainModel
    {
        public async Task<DataTable> GetFriedns()
        {
            var connect = new DataBase.DataReader(@"C:\Users\trokh\source\repos\OTSC\OTSC\DataBase\ConfigData.json");
            string query = "SELECT * FROM users";
            try
            {
                using(NpgsqlConnection connection=new NpgsqlConnection(connect.СonnectionString))
                {
                    await connection.OpenAsync();
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
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
