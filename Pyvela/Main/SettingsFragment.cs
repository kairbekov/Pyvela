using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Pyvela.Main.Entrance;

namespace Pyvela.Main
{
    public class SettingsFragment : Android.Support.V4.App.Fragment
    {
        private SplashActivity splashActivity;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            splashActivity = new SplashActivity();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root = inflater.Inflate(Resource.Layout.settings_frag, container, false);
            Button exit = root.FindViewById<Button>(Resource.Id.exit1);

            exit.Click += ExitClick;

            return root;
        }

        private void ExitClick(object sender, EventArgs e)
        {
            splashActivity.AppPreferences(Activity);
            splashActivity.SaveAccessKey("Bool", true);

            Intent intent = new Intent(Activity, typeof(EntranceActivity));
            StartActivity(intent);
        }
    }
}