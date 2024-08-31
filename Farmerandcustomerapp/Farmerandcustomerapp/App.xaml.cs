using Microsoft.Maui.Controls;

namespace Farmerandcustomerapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FarmerLoginPage());
        }
    }
}
