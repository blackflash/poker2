using System.Threading;
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Poker2
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Landscape)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //Thread.Sleep(10000); // Simulate a long loading process on app startup.
            StartActivity(typeof(MainActivity));
        }
    }
}