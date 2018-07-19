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
using Android.Support.V4.App;

namespace Pyvela.Main.Entrance
{
    [Activity(Label = "EntranceActivtiy", Theme = "@style/AppTheme.NoActionBar")]
    public class EntranceActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.entrance_act);
            base.OnCreate(savedInstanceState);
            SupportFragmentManager.BeginTransaction()
                .Add(Resource.Id.entrance_fragment_placeholder ,new AuthorizationFragment())
                .Commit();
        }

        public void ReplaceFragment(Android.Support.V4.App.Fragment fragment)
        {
            SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.entrance_fragment_placeholder, fragment)
                .SetTransition((int)FragmentTransit.FragmentOpen)
                .Commit();
        }
    }
}