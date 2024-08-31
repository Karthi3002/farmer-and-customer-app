using Microsoft.Maui.Controls;
using System;

namespace Farmerandcustomerapp
{
    public partial class ConfirmationPage : ContentPage
    {
        public ConfirmationPage()
        {
            InitializeComponent();
        }

        private async void OnBackToDashboardClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CustomerDashboardPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
