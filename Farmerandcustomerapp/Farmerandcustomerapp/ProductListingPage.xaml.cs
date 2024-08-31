using Microsoft.Maui.Controls;
using System;

namespace Farmerandcustomerapp
{
    public partial class ProductListingPage : ContentPage
    {
        public ProductListingPage()
        {
            InitializeComponent();
        }

        private async void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string productName = productNameEntry.Text;
                int quantity = int.Parse(quantityEntry.Text);
                decimal price = decimal.Parse(priceEntry.Text);

                // Add product to database logic here (dummy implementation)
                var product = new Models.Product
                {
                    Name = productName,
                    Quantity = quantity,
                    Price = price
                };

                // Navigate back to FarmerDashboardPage
                await Navigation.PushAsync(new FarmerDashboardPage());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
