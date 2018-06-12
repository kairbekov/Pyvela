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

namespace Pyvela
{
    class RegistrationPage
    {

        [Activity(Label = "Login", MainLauncher = true)]
        public class MainActivity : Activity
        {

            protected override void OnCreate(Bundle bundle)
            {
                base.OnCreate(bundle);

                SetContentView(Resource.Layout.RegistrationPage);


            }
        }
    }