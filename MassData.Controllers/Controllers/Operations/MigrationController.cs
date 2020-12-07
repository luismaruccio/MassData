using MassData.Database.Connections;
using MassData.Database.Migrations;
using MassData.Helpers.Helpers;
using MassData.Models.Models;
using System;
using System.Collections.Generic;

namespace MassData.Controllers.Controllers.Operations
{
    internal class MigrationController
    {
        private Connection connectionInstance;
        private InitializeController InitializeController;
        public MigrationController(Connection connection, InitializeController initializeController)
        {
            connectionInstance = connection;
            InitializeController = initializeController;
        }

        public bool Migrate()
        {
            if (!connectionInstance.CheckIfTableExists(MigrationModel.GetTableName()))
            {
                InitializeController.SetStage("Criando tabela de migração");
                connectionInstance.ExecuteNonQuery(MigrationHelper.GetSQLCreateMigrationTable());
            }

            InitializeController.SetStage("Obtendo migrações");
            List<MigrationModel> migrationModels = MigrationModel.ParseReaderToList(connectionInstance.ExecuteQuery(MigrationModel.GetSQLGetAll()));

            List<Migrations> migrations = Migrations.GetMigrations();

            foreach (var migration in migrations)
            {
                if (!migrationModels.Exists(x => x.Key == migration.Key))
                {
                    try
                    {
                        InitializeController.SetStage(migration.TitleShow);
                        connectionInstance.BeginTransaction();
                        connectionInstance.ExecuteNonQuery(migration.Sql);
                        connectionInstance.ExecuteNonQuery(MigrationModel.GetSQLInsert(migration.Key));
                        connectionInstance.CommitTransaction();
                    }
                    catch (Exception)
                    {
                        connectionInstance.RollBackTransaction();
                        //MessageController - Show Error
                        throw;
                    }
                }
            }

            return true;
        }
    }
}
