using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using com.refractored.monodroidtoolkit;

namespace Poker2
{
    [Activity(Label = "Poker2MadHack", MainLauncher = false,ScreenOrientation = ScreenOrientation.Landscape, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it

            var createGameButton = FindViewById<ImageButton>(Resource.Id.myButton);
            createGameButton.Click += delegate { StartActivity(typeof(InGame));};

            

            //var joinGamebutton = FindViewById<Button>(Resource.Id.JoinGameButton);
            //joinGamebutton.Click += delegate { StartActivity(typeof(JoinGame)); };
        }
    }
}

