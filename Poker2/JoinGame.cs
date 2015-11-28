using Android.App;
using Android.OS;

namespace Poker2
{
    [Activity(Label = "JoinGame")]
    public class JoinGame : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.JoinGame);
            // Create your application here
        }
    }
}