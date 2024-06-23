using Foundation;

using Plugin.MauiMTAdmob;

using UIKit;

namespace AdmobTest
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public AppDelegate()
        {
            // 추가
            CrossMauiMTAdmob.Current.Init();
        }

        // 추가
        public override void OnActivated(UIApplication application)
        {
            base.OnActivated(application);
            CrossMauiMTAdmob.Current.OnResume();
        }
    }
}
