using MassData.Controllers.Controllers.Views;
using System.Windows.Forms;

namespace MassData.StartUp.Contexts
{
    class MassDataContext : ApplicationContext
    {
        public MassDataContext()
        {
            MainController mainController = new MainController();

            mainController.Start();
        }
    }
}
