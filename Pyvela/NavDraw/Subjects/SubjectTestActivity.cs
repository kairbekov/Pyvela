using Pyvela.Utils.Adapters;
using System.Text;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace Pyvela.NavDraw.Subjects
{
    [Activity(Label = "SubjectTestActivity")]
    public class SubjectTestActivity : Android.Support.V4.App.FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {   
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.subject_test_act);
            ActionBar.Hide();
            
            ViewPager viewPager = (ViewPager)FindViewById(Resource.Id.subject_test_viewPager);
            viewPager.Adapter = new SubjectTestAdapter(SupportFragmentManager);
            
        }
    }
}