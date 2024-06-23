using Plugin.MauiMTAdmob;

namespace AdmobTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CrossMauiMTAdmob.Current.ComplyWithFamilyPolicies = true;
            CrossMauiMTAdmob.Current.UseRestrictedDataProcessing = true;
            CrossMauiMTAdmob.Current.AdsId = DeviceInfo.Platform == DevicePlatform.Android ? "ca-app-pub-2643538289217660~5183062697" : "ca-app-pub-2643538289217660~9889428618";
            //CrossMauiMTAdmob.Current.TestDevices = new List<string>() { };

            MainPage = new AppShell();
        }
    }
}
