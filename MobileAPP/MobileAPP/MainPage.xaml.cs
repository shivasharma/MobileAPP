using Xamarin.Forms;

namespace MSTL
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Master = new Master();
            Detail = new NavigationPage(new Home());
            App.MasterDetail = this;
        }
    }
}