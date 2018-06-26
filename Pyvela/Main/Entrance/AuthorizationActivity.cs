using Pyvela.Main.Entrance;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Pyvela.Main.Entrance
{
    [Activity(Label = "AuthorizationActivity")]
    public class AuthorizationActivity : Activity
    {
        private Handler mHandler;
        Button SignUpBut, SignInBut;
        ImageView imageView;
        EditText LoginText, PasswordText;
        
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.auth_act);

            mHandler = new Handler();

            Bundle bundle = Intent.Extras;
            
            

            imageView = FindViewById<ImageView>(Resource.Id.imageView1);

            SignUpBut = FindViewById<Button>(Resource.Id.button1);
            SignInBut = FindViewById<Button>(Resource.Id.button2);
            LoginText = FindViewById<EditText>(Resource.Id.editText1);
            PasswordText = FindViewById<EditText>(Resource.Id.editText2);

            

            SignUpBut.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(RegistrationActivity));
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
        bool twice;
        public override void OnBackPressed()
        {

            if (twice==true)
            {
                Intent intent = new Intent(Intent.ActionMain);
                intent.AddCategory(Intent.CategoryHome);
                intent.SetFlags(ActivityFlags.ClearTop);
                StartActivity(intent);

            }


            Toast.MakeText(this, "Please press BACK again to exit", ToastLength.Short).Show();

            Handler handler = new Handler();
            handler.PostDelayed( new Runnable(()=> {

                
                    twice = false;

            }) , 1500);
            twice = true;

            
        }
        

        
    }
    
}