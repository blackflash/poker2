using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using com.refractored.monodroidtoolkit;
using Android.Content.PM;

namespace Poker2
{
    [Activity(Label = "Poker2MadHack", MainLauncher = false, ScreenOrientation = ScreenOrientation.Landscape, Icon = "@drawable/icon")]
    public class InGame : Activity
    {
        private HoloCircularProgressBar m_Progress;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.InGame);
            // Create your application here

            m_Progress = FindViewById<HoloCircularProgressBar>(Resource.Id.holoCircularProgressBar1);
            m_Progress.CircleStrokeWidth = 20;
            m_Progress.Progress = 40;
            m_Progress.ProgressBackgroundColor = Android.Graphics.Color.Red;
            m_Progress.ProgressColor = Android.Graphics.Color.Transparent;
        }
    }
}