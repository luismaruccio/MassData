using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;

namespace MassData.Database.Connections
{
    internal class Connection
    {
        private SQLiteConnection connectionInstance;
        private SQLiteTransaction transactionInstance;
        private readonly string dataBaseName = "database.db";

        public Connection()
        {
            string connectionString = "DataSource = " + dataBaseName + "; Version = 3;" + (File.Exists(dataBaseName) ? "" : "New = True;Compress = True;");

            connectionInstance = new SQLiteConnection(connectionString);
            connectionInstance.Open();
        }

        internal bool IsConnected()
        {
            return connectionInstance.State == System.Data.ConnectionState.Open;
        }

        internal DbDataReader ExecuteQuery(string sql)
        {
            DbCommand command = connectionInstance.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteReader();
        }

        internal bool CheckIfTableExists(string tableName)
        {
            DbCommand command = connectionInstance.CreateCommand();
            command.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type = 'table' AND name = '"+ tableName +"'";
            long count = (long)command.ExecuteScalar();

            return count != 0;            
        }

        internal int ExecuteNonQuery(string sql, bool transaction = false)
        {
            DbCommand command = connectionInstance.CreateCommand();
            if (transaction)
                command.Transaction = transactionInstance;
            command.CommandText = sql;
            return command.ExecuteNonQuery();
        }

        internal void BeginTransaction()
        {
            transactionInstance = connectionInstance.BeginTransaction();
        }

        internal void RollBackTransaction()
        {
            transactionInstance.Rollback();
        }

        internal void CommitTransaction()
        {
            transactionInstance.Commit();
        }

        internal DataTable CastDataReader(DbDataReader dbDataReader)
        {
            DataTable dt = new DataTable();
            dt.Load(dbDataReader);
            return dt;
        }
    }
}
