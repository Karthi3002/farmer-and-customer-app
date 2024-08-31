using Microsoft.Maui.Controls;
using System;

namespace Farmerandcustomerapp
{
    public partial class ProductDetailsPage : ContentPage
    {
        private Models.Product _product;

        public ProductDetailsPage(Models.Product product)
        {
            InitializeComponent();
            _product = product;
            BindProductDetails();
        }

        private void BindProductDetails()
        {
            try
            {
                productNameLabel.Text = _product.Name;
                productPriceLabel.Text = $"Price: {_product.Price:C}";
                productQuantityLabel.Text = $"Available Quantity: {_product.Quantity}";
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnPurchaseButtonClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PaymentPage(_product));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
