using Xamarin.Forms;

namespace MSTL
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new MSTL.Home());
            App.MasterDetail = this;
        }
    }
}
