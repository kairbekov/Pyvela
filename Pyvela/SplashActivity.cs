using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Pyvela
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        private ISharedPreferences SharedPrefs;
        private ISharedPreferencesEditor PrefsEditor;
        private Context mContext;


        static readonly string TAG = "X:" + typeof(SplashActivity).Name;

        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
            Log.Debug(TAG, "SplashActivity.OnCreate");

        }

        public void AppPreferences(Context context)
        {
            mContext = context;
            SharedPrefs = PreferenceManager.GetDefaultSharedPreferences(mContext);
            PrefsEditor = SharedPrefs.Edit();
        }

        public void SaveAccessKey(string Name, bool bl)
        {
            PrefsEditor.PutString("Name", Name);
            PrefsEditor.PutBoolean("Bool", bl);
            PrefsEditor.Commit();
            Toast.MakeText(this, SharedPrefs.GetString("Name", "hello"), ToastLength.Short).Show();
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();

            AppPreferences(this);
            SaveAccessKey("Nurlan", false);

            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {

            Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
            await Task.Delay(5000); // Simulate a bit of startup work.
            Log.Debug(TAG, "Startup work is finished - starting MainActivity.");
            if (SharedPrefs.GetBoolean("Bool", false)==false)
            {
                StartActivity(new Intent(Application.Context, typeof(AuthorizationActivity)));

            }
            else
                StartActivity(new Intent(Application.Context, typeof(SubjectsActivity)));
        }

    }
}