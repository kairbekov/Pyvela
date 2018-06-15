using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Pyvela
{
    [Activity(Label = "Pyvela", Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SubjectsPage);
        }
    }
}

