using Microsoft.Maui.Controls;
using System;

namespace Farmerandcustomerapp
{
    public partial class PaymentPage : ContentPage
    {
        private Models.Product _product;

        public PaymentPage(Models.Product product)
        {
            InitializeComponent();
            _product = product;
        }

        private async void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var payment = new Models.Payment
                {
                    CardNumber = cardNumberEntry.Text,
                    CardHolderName = cardHolderNameEntry.Text,
                    ExpiryDate = expiryDateEntry.Text,
                    CVV = cvvEntry.Text
                };

                // Dummy payment processing logic
                bool isPaymentSuccessful = ProcessPayment(payment);

                if (isPaymentSuccessful)
                {
                    await Navigation.PushAsync(new ConfirmationPage());
                }
                else
                {
                    await DisplayAlert("Error", "Payment failed. Please try again.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private bool ProcessPayment(Models.Payment payment)
        {
            // Dummy implementation for payment processing
            // In a real application, you would integrate with a payment gateway
            return true;
        }
    }
}
