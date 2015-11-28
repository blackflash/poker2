using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Poker2MadHack;

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

            var createGamebutton = FindViewById<Button>(Resource.Id.CreateGameButton);
            createGamebutton.Click += delegate { StartActivity(typeof(CreateGame));};
        
            var joinGamebutton = FindViewById<Button>(Resource.Id.JoinGameButton);
            joinGamebutton.Click += delegate { StartActivity(typeof(JoinGame)); };
        }
    }
}

