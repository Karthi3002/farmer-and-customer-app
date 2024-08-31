using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Farmerandcustomerapp
{
    public partial class ProductSearchPage : ContentPage
    {
        private ObservableCollection<Models.Product> products;

        public ProductSearchPage()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            // Dummy data for demonstration purposes
            products = new ObservableCollection<Models.Product>
            {
                new Models.Product { Name = "Apples", Price = 1.20m },
                new Models.Product { Name = "Bananas", Price = 0.80m },
                new Models.Product { Name = "Carrots", Price = 0.50m }
            };

            productsCollectionView.ItemsSource = products;
        }

        private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string searchText = e.NewTextValue.ToLower();
                productsCollectionView.ItemsSource = products.Where(p => p.Name.ToLower().Contains(searchText));
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private async void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var selectedProduct = e.CurrentSelection.FirstOrDefault() as Models.Product;
                if (selectedProduct != null)
                {
                    await Navigation.PushAsync(new ProductDetailsPage(selectedProduct));
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}
