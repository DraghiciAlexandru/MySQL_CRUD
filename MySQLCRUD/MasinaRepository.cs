using MySqlDataAcces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace MySQLCRUD
{
    public class MasinaRepository
    {

        private readonly string connectionString;

        private DataAcces db;

        public MasinaRepository()
        {
            db= new DataAcces();

            var builder = new ConfigurationBuilder().SetBasePath(@"D:\MyCode\C#\DataAcces\Dapper\MySQLCRUD\MySQLCRUD")
                .AddJsonFile("appsettings.json");


            var config = builder.Build();

            this.connectionString = config.GetConnectionString("Default");

        }


        public List<Masina> getAll()
        {

            string sql = "SELECT *FROM masini";


            return db.LoadData<Masina, dynamic>(sql, new { }, connectionString);
        }

        //CRUD

        public void create(Masina masina)
        {
            string sql = "insert into masini (model,an,culoare)values(@model,@an,@culoare);";

            db.SaveData(sql, new {masina.Model, masina.An, masina.Culoare}, connectionString);

        }

        public Masina getModel(string model)
        {
            string sql = "select * from masini where model = @model";

            return (db.LoadData<Masina, dynamic>(sql, new { model}, connectionString))[0];
        }

        public Masina getById(int id)
        {
            string sql = "select * from masini where id = @id";
            if (db.LoadData<Masina, dynamic>(sql, new {id}, connectionString).Count == 0)
                return null;
            return db.LoadData<Masina, dynamic>(sql, new {id}, connectionString)[0];
        }

        public void deleteById(int id)
        {
            string sql ="delete from masini where id = @id";

            db.SaveData(sql, new {id}, connectionString);
        }

        public void updateModelById(int id, string model)
        {
            string sql = "update masini set model =@model where id =@id";

            db.SaveData(sql, new {model, id}, connectionString);
        }

        public void updateAnById(int id, int an)
        {
            string sql = "update masini set an =@an where id =@id";

            db.SaveData(sql, new {an, id}, connectionString);
        }

        public void updateCuloareById(int id, string culoare)
        {
            string sql = "update masini set culoare =@culoare where id =@id";

            db.SaveData(sql, new {culoare, id}, connectionString);
        }
    }
}
