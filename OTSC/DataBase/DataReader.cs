using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Npgsql;
using System.Text.Json.Serialization;
namespace OTSC.DataBase
{
    public class DataReader
    {
        public string СonnectionString { get; }
        public DataReader(string filePath)
        {

            string jsonString = File.ReadAllText(filePath);
            var config = System.Text.Json.JsonSerializer.Deserialize<ConnectTODB>(jsonString);
            Console.WriteLine($"Deserialized config: {config.Host}, {config.Port}, {config.Username}, {config.Database}");

            // Проверка на null или пустые строки
            if (string.IsNullOrEmpty(config.Host) || string.IsNullOrEmpty(config.Port) ||
                string.IsNullOrEmpty(config.Username) || string.IsNullOrEmpty(config.Password) ||
                string.IsNullOrEmpty(config.Database))
            {
                throw new ArgumentException("One or more connection parameters are missing in the config file.");
            }

            СonnectionString = $"Host={config.Host};Port={config.Port};Username={config.Username};Password={config.Password};Database={config.Database}";
        }
        }
    public class ConnectTODB
    {
        [JsonProperty("Host")]
        public string? Host { get; set; }

        [JsonProperty("Port")]
        public string? Port { get; set; }

        [JsonProperty("Username")]
        public string? Username { get; set; }

        [JsonProperty("Password")]
        public string? Password { get; set; }

        [JsonProperty("Database")]
        public string? Database { get; set; }
    }

}
