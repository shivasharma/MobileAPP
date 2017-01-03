using System.Threading.Tasks;
using Xamarin.Forms;

namespace MSTL
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static MasterDetailPage MasterDetail { get; set; }

        public static async Task NavigationMasterDetail(Page page)
        {
            MasterDetail.IsPresented = false;
            await MasterDetail.Detail.Navigation.PushAsync(page);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}