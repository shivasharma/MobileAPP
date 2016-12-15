using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileAPP
{
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
            buttonAbout.Clicked += async (sender, e) =>
             {
                 await App.NavigationMasterDetail(new About());
             };

            buttonHome.Clicked += async (sender, e) =>
            {
                await App.NavigationMasterDetail(new Home());
            };
            buttonService.Clicked += async (sender, e) =>
            {
                await App.NavigationMasterDetail(new Service());
            };
            buttonContact.Clicked += async (sender, e) =>
            {
                await App.NavigationMasterDetail(new Contact());
            };
        }
    }
}
