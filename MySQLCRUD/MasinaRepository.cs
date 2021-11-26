using MySqlDataAcces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace MySQLCRUD
{


    class MasinaRepository
    {

        private readonly string connectionString;
        private DataAcces db;

        public MasinaRepository()
        {

            var builder = new ConfigurationBuilder().SetBasePath(@"D:\MyCode\C#\DataAcces\Dapper\MySQLCRUD\MySQLCRUD")
                .AddJsonFile("appsettings.json");


            var config = builder.Build();

            this.connectionString = config.GetConnectionString("Default");

        }


        public List<Masina> getAll()
        {

            string sql = "select id, model, an, culoare from masini";


            return db.LoadData<Masina, dynamic>(sql, new { }, connectionString);
        }
    }
}
