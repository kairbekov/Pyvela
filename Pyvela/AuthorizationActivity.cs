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
    [Activity(Label = "AuthorizationActivity")]
    public class AuthorizationActivity : Activity
    {
        Button SignUpBut, SignInBut;
        ImageView imageView;
        EditText LoginText, PasswordText;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AuthorizationLayout);
            imageView = FindViewById<ImageView>(Resource.Id.imageView1);

            SignUpBut = FindViewById<Button>(Resource.Id.button1);
            SignInBut = FindViewById<Button>(Resource.Id.button2);
            LoginText = FindViewById<EditText>(Resource.Id.editText1);
            PasswordText = FindViewById<EditText>(Resource.Id.editText2);

            SignUpBut.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(RegistrationPage));
                StartActivity(intent);
            };

            SignInBut.Click += (s, e) =>
            {
                /*
                if (LoginText.Text.Length == 0 || PasswordText.Text.Length == 0)
                {
                    Toast.MakeText(this, "Error", ToastLength.Short).Show();
                }
                else
                {
                    var intent = new Intent(this, typeof(Subject));
                    StartActivity(intent);
                }
                */
                var intent = new Intent(this, typeof(MainActivity));
                StartActivity(intent);
            };
        }
    }
}