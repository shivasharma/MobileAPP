using Xamarin.Forms;

namespace MSTL
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
                await App.NavigationMasterDetail(new MSTL.Home());
            };
            buttonService.Clicked += async (sender, e) =>
            {
                await App.NavigationMasterDetail(new Service());
            };
            buttonContact.Clicked += async (sender, e) =>
            {
                await App.NavigationMasterDetail(new MSTL.Contact());
            };
        }
    }
}
