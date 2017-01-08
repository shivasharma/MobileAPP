using Android.App;
using Android.Content.PM;
using Android.OS;
using MSTL.Droid;

namespace MobileAPP.Droid
{
    //[Activity(Label = "MSTL", Icon = "@drawable/icon", Theme = "@style/MyTheme",
    //    MainLauncher = false,
    //    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    [Activity()]
    public class MainActivity : Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new MSTL.App());
        }
    }
}

