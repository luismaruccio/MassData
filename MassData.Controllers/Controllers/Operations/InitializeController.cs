using MassData.Database.Connections;
using System;
using System.Threading;

namespace MassData.Controllers.Controllers.Operations
{
    class InitializeController
    {
        public event EventHandler<HardWorkerEventArgs> StageChanged;
        public event EventHandler HardWorkDone;

        private Connection connection;

        public void SetStage(string stage)
        {
            OnProgressChanged(stage);
        }

        public void SetDone()
        {
            OnHardWorkDone();
        }

        public void DoHardWork()
        {
            Thread.Sleep(1000);
            InitializeDatabase();
        }

        private void OnProgressChanged(string stage)
        {
            StageChanged?.Invoke(this, new HardWorkerEventArgs(stage));
        }
        private void OnHardWorkDone()
        {
            HardWorkDone?.Invoke(this, EventArgs.Empty);
        }

        private void InitializeDatabase()
        { 
            if (InitializeConnection())
            {
                OnProgressChanged("Atualizando estruturas do banco");
                MigrationController migrationController = new MigrationController(connection, this);
                migrationController.Migrate();                   
            }

            OnHardWorkDone();
        }

        private bool InitializeConnection()
        {
            OnProgressChanged("Inicializando Conexão");
            connection = new Connection();

            return connection.IsConnected();
        }

        internal Connection GetConnection()
        {
            return connection;
        }
    }

    internal class HardWorkerEventArgs : EventArgs
    {
        public HardWorkerEventArgs(string stage)
        {
            Stage = stage;
        }
        public string Stage
        {
            get;
            private set;
        }
    }
}
