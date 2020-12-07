using System.Collections.Generic;

namespace MassData.Database.Migrations
{
    internal class Migrations
    {
        private string key; //Max 60 caracteres
        private string sql;
        private string titleShow;

        internal string Sql
        {
            get { return sql; }
        }


        internal string Key
        {
            get { return key; }
        }

        internal string TitleShow
        {
            get { return titleShow; }
        }

        internal static List<Migrations> GetMigrations()
        {
            List<Migrations> migrations = new List<Migrations>();

            //Create Table Layouts
            migrations.Add(new Migrations()
            {
                key = "CreateTableLayouts",
                titleShow = "Criando tabela de layouts",
                sql = "CREATE TABLE layouts (" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                        "name VARCHAR(60) NOT NULL, " +
                        "obs TEXT " +
                      ");" +
                      "CREATE INDEX idx_name " +
                        "ON layouts(name);"
            });

            //Create Table LayoutsFields
            migrations.Add(new Migrations()
            {
                key = "CreateTableLayoutsFields",
                titleShow = "Criando tabela de campos do layout",
                sql = "CREATE TABLE layoutsFields (" +
                        "id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                        "layout INTEGER NOT NULL," +
                        "name VARCHAR(60) NOT NULL, " +
                        "dataType STRING NOT NULL, " +
                        "dataGeneration STRING NOT NULL, " +
                        "generationConditions TEXT, " +
                        "obs TEXT, " +
                        "FOREIGN KEY(layout) REFERENCES layout(id) " +
                      ");" +
                      "CREATE UNIQUE INDEX idx_unique_layouts " +
                        "ON layoutsFields(id,layout);"
            }); ;

            return migrations;
        }
    }
}
