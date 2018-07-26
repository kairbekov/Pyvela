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
using Pyvela.Data.Remote;

namespace Pyvela.Main.Entrance
{
    public class AuthorizationFragment : Android.Support.V4.App.Fragment
    {
        private EntranceActivity Parent;
        private DataBaseClass dataBaseClass;
        private Button AuthSignIn, AuthSignUp;
        private EditText AuthLogin, AuthPass;
        private SplashActivity splashActivity;

        public override void OnAttach(Context context)
        {
            this.Parent = (EntranceActivity)context;
            base.OnAttach(context);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            dataBaseClass = new DataBaseClass();
            dataBaseClass.DataBase();

            splashActivity = new SplashActivity();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root = inflater.Inflate(Resource.Layout.auth_frag, container, false);
            AuthSignIn = root.FindViewById<Button>(Resource.Id.auth_sign_in);
            AuthSignUp = root.FindViewById<Button>(Resource.Id.auth_sign_up);
            AuthLogin = root.FindViewById<EditText>(Resource.Id.auth_login);
            AuthPass = root.FindViewById<EditText>(Resource.Id.auth_password);

            AuthSignIn.Click += AuthSignInClick;
            AuthSignUp.Click += AuthSignUpClick;
        
            return root;
        }

        private void AuthSignUpClick(object sender, EventArgs e)
        {
            Parent.ReplaceFragment(new RegistrationFragment());
        }

        private void AuthSignInClick(object sender, EventArgs e)
        {
            bool check;
            string email = AuthLogin.Text;
            string pass = AuthPass.Text;
            check = dataBaseClass.Entrance(email, pass);
            if (check == true)
            {
                splashActivity.AppPreferences(Activity);
                splashActivity.SaveAccessKey("Bool", false);

                Intent intent = new Intent(Activity, typeof(MainActivity));
                StartActivity(intent);
            }
            else
                Toast.MakeText(Activity, "Error", ToastLength.Short).Show();
        }
    }
}