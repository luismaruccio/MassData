using MassData.Database.Connections;
using MassData.Models.Models;
using MassData.Views.Forms;

namespace MassData.Controllers.Controllers.Views
{
    public class MainController
    {
        private Connection connection;
        private FMain view;
        public void Start()
        {
            var splashController = new SplashController();
            splashController.Initialize();
            connection = splashController.connection;
            LoadForm();
        }

        private void LoadForm()
        {
            view = new FMain();
            LoadLayouts();
            view.Show();
        }

        private void LoadLayouts()
        {
            view.SetLayouts(connection.CastDataReader(connection.ExecuteQuery(LayoutModel.GetSqlSelect())));
        }
    }
}
