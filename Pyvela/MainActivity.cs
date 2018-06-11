using Android.App;
using Android.Widget;
using Android.OS;

namespace Pyvela
{
    [Activity(Label = "Pyvela", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            gdhm
            // Get our button from the layout resource,
            // and attach an event to itghjk
            Button button = FindViewById<Button>(Resource.Id.myButton);

            button.Click += delegate { button.Text = $"{count++} clicks!"; };
            // Hello world!
        }
    }
}

