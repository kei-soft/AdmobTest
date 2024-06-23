using Android.App;
using Android.Content.PM;
using Android.OS;

using Plugin.MauiMTAdmob;

namespace AdmobTest
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // 추가
            string appId = "ca-app-pub-2643538289217660~5183062697";
            CrossMauiMTAdmob.Current.Init(this, appId);
        }

        // 추가
        protected override void OnResume()
        {
            base.OnResume();
            CrossMauiMTAdmob.Current.OnResume();
        }
    }
}
