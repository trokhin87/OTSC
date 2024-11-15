using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Npgsql;
namespace OTSC.DataBase
{
    public class DataReader
    {
        public readonly NpgsqlConnection con;
        public readonly NpgsqlCommand cmd;
        public DataReader(string filePath) 
        {
            string jsonString = File.ReadAllText(filePath);
            var config = JsonSerializer.Deserialize<ConnectTODB>(jsonString);

            string connectionString = $"Host={config.Host};Port={config.Port};Username={config.Username};Password={config.Password};Database={config.Database};";
            con = new NpgsqlConnection(connectionString);
            cmd.Connection = con;
        }
    }
    public class ConnectTODB
    {
        internal string? Host { get; set; }
        internal string? Port { get; set; }
        internal string? Username { get; set; }
        internal string? Password { get; set; }
        internal string? Database { get; set; }
    }

}
