using Android.App;
using Android.Content.PM;
using Android.OS;
using Poker2.Resources.Helpers;


namespace Poker2
{
    [Activity(Label = "CreateGame", ScreenOrientation = ScreenOrientation.Landscape)]
    public class CreateGame : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CreateGame);
            var createGamebutton = FindViewById<Android.Widget.Button>(Resource.Id.calculate);
            createGamebutton.Click += delegate
            {
                var blindhelper = new BlindsHelper();
                var players = FindViewById<Android.Widget.EditText>(Resource.Id.numberofplayers);
                var hours = FindViewById<Android.Widget.EditText>(Resource.Id.numberofhours);
                double hoursD;
                double playersD;
                
                var hoursValid = double.TryParse(hours.Text, out hoursD);
                var numberofplayersValid = double.TryParse(players.Text, out playersD);
                if (hoursValid && numberofplayersValid)
                {
                    var timeinMS = blindhelper.GetBlindTimeInMS(hoursD, playersD);
                    var timeinMin = timeinMS/1000/60; 
                    var resulttext = FindViewById<Android.Widget.TextView>(Resource.Id.timeperblindtext);
                    resulttext.Text = timeinMin + " minutes";
                }

            };

            // Create your application here
        }
    }
}