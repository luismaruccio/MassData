using System;
using System.Collections.Generic;
using System.Data.Common;

namespace MassData.Models.Models
{
    internal class MigrationModel
    {
        private static readonly string TableName = "migrations";

        internal int Id;
        internal string Key;
        internal DateTime Date;

        internal static string GetSQLGetAll()
        {
            return "SELECT * FROM " + TableName;
        }

        internal static List<MigrationModel> ParseReaderToList(DbDataReader dataReader)
        {
            List<MigrationModel> list = new List<MigrationModel>();
            while (dataReader.Read())
            {
                MigrationModel migrationModel = new MigrationModel();
                migrationModel.Id = dataReader.GetInt32(0);
                migrationModel.Key = dataReader.GetString(1);
                migrationModel.Date = dataReader.GetDateTime(2);

                list.Add(migrationModel);
            }

            return list;
        }

        internal static string GetTableName()
        {
            return TableName;
        }

        internal static string GetSQLInsert(string key)
        {
            return "INSERT INTO migrations ( " +
                "key, " +
                "date " +
                ") " +
                "VALUES ( " +
                "'" + key + "', " +
                "DATE('now') " +
                ");";
        }
    }
}
