using Pyvela.Main.Entrance;
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
            
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();

            AppPreferences(this);
            SaveAccessKey("Nurlan", false);

            if (SharedPrefs.GetBoolean("Bool", false) == false)
            {
                Intent intent = new Intent(this, typeof(AuthorizationActivity));
                
                StartActivity(intent);
            }
            else
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}