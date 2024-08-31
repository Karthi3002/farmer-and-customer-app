using Microsoft.Maui.Controls;
using System;

namespace Farmerandcustomerapp
{
    public partial class FarmerLoginPage : ContentPage
    {
        public FarmerLoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string email = emailEntry.Text;
                string password = passwordEntry.Text;

                // Dummy validation for demonstration purposes
                if (email == "farmer@example.com" && password == "password")
                {
                    await Navigation.PushAsync(new FarmerDashboardPage());
                }
                else
                {
                    await DisplayAlert("Error", "Invalid email or password", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
