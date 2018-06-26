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

namespace Pyvela.Main.Specialization
{
    public class SettingsFragment : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View root= inflater.Inflate(Resource.Layout.setting_frag1, container, false);
            Button button = (Button)root.FindViewById(Resource.Id.specialitiesbutton);

            button.Click += (s, e) =>
            {
                Intent intent = new Intent(Activity, typeof(SpecialityActivity));
                Activity.StartActivity(intent);

            };
            return root;

        }
    }
}