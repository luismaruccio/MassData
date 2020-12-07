using MassData.Controllers.Controllers.Operations;
using MassData.Database.Connections;
using MassData.Views.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MassData.Controllers.Controllers.Views
{
    class SplashController
    {
        private FSplash view;
        private bool done = false;
        internal Connection connection;

        public SplashController()
        {
            view = new FSplash();
        }

        internal void Initialize()
        {
            Thread thread = new Thread(new ThreadStart(Show));
            thread.Start();
            InitializeController worker = new InitializeController();
            worker.StageChanged += (o, ex) =>
            {
                this.view.UpdateStage(ex.Stage);
            };
            worker.HardWorkDone += (o, ex) =>
            {
                done = true;
                connection = worker.GetConnection();
            };
            worker.DoHardWork();
        }

        internal void Show()
        {
            view.Show();
            while (!done)
            {
                Application.DoEvents();
            }
            view.Close();
            view.Dispose();
        }
    }
}
