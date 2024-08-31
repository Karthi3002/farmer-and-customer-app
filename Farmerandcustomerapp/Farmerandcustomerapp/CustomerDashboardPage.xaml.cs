using Microsoft.Maui.Controls;
using System;

namespace Farmerandcustomerapp
{
    public partial class CustomerDashboardPage : ContentPage
    {
        public CustomerDashboardPage()
        {
            InitializeComponent();
        }

        private async void OnSearchForProductsClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ProductSearchPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnViewNearbyOptionsClicked(object sender, EventArgs e)
        {
            try
            {
                // Navigate to NearbyOptionsPage (assuming it exists)
                await Navigation.PushAsync(new NearbyOptionsPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnMakePurchasesClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PaymentPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
