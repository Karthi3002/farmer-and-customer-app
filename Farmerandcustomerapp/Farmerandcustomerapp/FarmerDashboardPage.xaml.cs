using Microsoft.Maui.Controls;
using System;

namespace Farmerandcustomerapp
{
    public partial class FarmerDashboardPage : ContentPage
    {
        public FarmerDashboardPage()
        {
            InitializeComponent();
        }

        private async void OnUpdateAndSellProductsClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ProductListingPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnViewSalesHistoryClicked(object sender, EventArgs e)
        {
            try
            {
                // Navigate to SalesHistoryPage (assuming it exists)
                await Navigation.PushAsync(new SalesHistoryPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnQRCodeFunctionalitiesClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new QRCodePage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
