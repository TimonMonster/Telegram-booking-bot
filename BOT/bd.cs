using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace BD
{

    public class Params
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Stars { get; set; }

        public string Resort { get; set; }
    }
    public class MyDatabase
    {
        private readonly string _connectionString;

        public MyDatabase(string host, int port, string databaseName, string username, string password)
        {
            _connectionString = $"Host={host};Port={port};Database={databaseName};Username={username};Password={password}";
        }

        public  Params InsertData(string name, string country, string city, string stars, string hotels)
        {
            using var connection = new NpgsqlConnection(_connectionString);
            connection.Open();
            Console.WriteLine("Connection successful");

            using var command = new NpgsqlCommand("INSERT INTO Resort (name, country, city, stars, hotels) VALUES (@name, @country, @city, @stars, @hotels)", connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@stars", stars);
            command.Parameters.AddWithValue("@hotels", hotels);
            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine("{0} rows were affected", rowsAffected);

            return new Params { Name = name, Country = country, City = city, Stars = stars , Resort = hotels };
        }

        static void Main(string[] args)
        {
            var myDatabase = new MyDatabase("Данные вашей бд");

        }
    }
}
