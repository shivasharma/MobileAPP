using System;
using Xamarin.Forms;

namespace MSTL
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

        }


        public async void CameraButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new About());
        }

        public async void TagButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new About());
        }

        public async void ShoppingButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new About());
        }

        public async void TwitterButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new About());
        }
    }
}
