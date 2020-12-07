using MassData.Controllers.Controllers.Operations;
using MassData.Database.Connections;
using System;
using System.Collections.Generic;
using System.Text;

namespace MassData.Controllers.Controllers.Views
{
    public class MainController
    {
        private Connection connection;
        public void Start()
        {
            var splashController = new SplashController();
            splashController.Initialize();
            connection = splashController.connection;
        }


    }
}
