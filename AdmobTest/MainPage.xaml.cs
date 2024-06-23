using Plugin.MauiMTAdmob;

namespace AdmobTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /* Test ID

            Android
            https://developers.google.com/admob/android/test-ads?hl=ko
            앱 오프닝 광고	            ca-app-pub-3940256099942544/3419835294
            배너 광고	                ca-app-pub-3940256099942544/6300978111
            전면 광고	                ca-app-pub-3940256099942544/1033173712
            전면 동영상 광고	        ca-app-pub-3940256099942544/8691691433
            보상형 광고	                ca-app-pub-3940256099942544/5224354917
            보상형 전면 광고	        ca-app-pub-3940256099942544/5354046379
            네이티브 광고 고급형	    ca-app-pub-3940256099942544/2247696110
            네이티브 동영상 광고 고급형	ca-app-pub-3940256099942544/1044960115

            iOS
            https://developers.google.com/admob/ios/test-ads#demo_ad_units
            앱 오프닝 광고	            ca-app-pub-3940256099942544/5662855259
            배너 광고	                ca-app-pub-3940256099942544/2934735716
            전면 광고	                ca-app-pub-3940256099942544/4411468910
            전면 동영상 광고	        ca-app-pub-3940256099942544/5135589807
            보상형 광고	                ca-app-pub-3940256099942544/1712485313
            보상형 전면 광고	        ca-app-pub-3940256099942544/6978759866
            네이티브 광고 고급형	    ca-app-pub-3940256099942544/3986624511
            네이티브 동영상 광고 고급형	ca-app-pub-3940256099942544/2521693316
             */

            if (DeviceInfo.Platform.Equals(DevicePlatform.Android))
            {
                this.mtAdView.AdsId = "ca-app-pub-3940256099942544/6300978111";
            }
            else
            {
                this.mtAdView.AdsId = "ca-app-pub-3940256099942544/2934735716";
            }

            // 전면광고 Loaded 완료시 전면광고 표시
            CrossMauiMTAdmob.Current.OnInterstitialLoaded += (s, e) => CrossMauiMTAdmob.Current.ShowInterstitial();
            // 전면광고 Close 시 이벤트
            CrossMauiMTAdmob.Current.OnInterstitialClosed += (s, e) => DisplayAlert("AdMobTest", "Interstitial Close", "OK");

            // 보상광고 Loaded 완료시 보상광고 표시
            CrossMauiMTAdmob.Current.OnRewardedLoaded += (s, e) => CrossMauiMTAdmob.Current.ShowRewarded();
            // 보상광고 Click 시 이벤트
            CrossMauiMTAdmob.Current.OnRewardedClicked += (s, e) => DisplayAlert("AdMobTest", "RewardedClicked", "OK");
            // 보상광고 Close 시 이벤트
            CrossMauiMTAdmob.Current.OnRewardedClosed += (s, e) => DisplayAlert("AdMobTest", "RewardedClosed", "OK");
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            /* 전면 광고 표시 */

            // 이미 로드되어있는 확인 - System.Exception: 'MTAdmob not initialised. You need to initialise it using CrossMauiMTAdmob.Current.Init in your platform projects!'
            bool isInterstitialLoaded = CrossMauiMTAdmob.Current.IsInterstitialLoaded();

            if (!isInterstitialLoaded)
            {
                if (DeviceInfo.Platform.Equals(DevicePlatform.Android))
                {
#if DEBUG
                    CrossMauiMTAdmob.Current.LoadInterstitial("ca-app-pub-3940256099942544/1033173712");
#else
                CrossMauiMTAdmob.Current.LoadInterstitial("ca-app-pub-3940256099942544/1033173712");
#endif
                }
                else
                {
#if DEBUG
                    CrossMauiMTAdmob.Current.LoadInterstitial("ca-app-pub-3940256099942544/4411468910");
#else
                CrossMauiMTAdmob.Current.LoadInterstitial("ca-app-pub-3940256099942544/4411468910");
#endif
                }
            }
        }

        private void RewardButton_Clicked(object sender, EventArgs e)
        {
            /* 보상 광고 표시 */

            // 이미 로드되어있는 확인
            bool IsRewardedLoaded = CrossMauiMTAdmob.Current.IsRewardedLoaded();

            if (!IsRewardedLoaded)
            {
                if (DeviceInfo.Platform.Equals(DevicePlatform.Android))
                {
#if DEBUG
                    CrossMauiMTAdmob.Current.LoadRewarded("ca-app-pub-3940256099942544/5224354917");
#else
                CrossMauiMTAdmob.Current.LoadRewarded("ca-app-pub-3940256099942544/5224354917");
#endif
                }
                else
                {
#if DEBUG
                    CrossMauiMTAdmob.Current.LoadRewarded("ca-app-pub-3940256099942544/1712485313");
#else
                CrossMauiMTAdmob.Current.LoadRewarded("cca-app-pub-3940256099942544/1712485313");
#endif
                }
            }
        }
    }

}
