using Android.App;
using Android.OS;

namespace Poker2
{
    [Activity(Label = "CreateGame")]
    public class CreateGame : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CreateGame);

            // Create your application here
        }
    }
}