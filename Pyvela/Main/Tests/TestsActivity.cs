using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Widget;
using Pyvela.Data.Local;

namespace Pyvela.Main.Tests
{
    [Activity(Label = "TestActivity")]
    public class TestsActivity : Android.Support.V4.App.FragmentActivity
    {
        private ViewPager viewPager;
        private TestsAdapter viewPagerAdapter;
        private Spinner spinner;
        private ArrayAdapter<string> spinnerAdapter;
        private int[] SubjectsId;

        protected override void OnCreate(Bundle savedInstanceState)
        {   
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.tests_act);

            SubjectsId = Intent.GetIntArrayExtra(Args.SUBJECTS_ID);
            TestsData.NewInstance(SubjectsId);
            FragmentsWatcher.NewInstance();

            spinner = (Spinner)FindViewById(Resource.Id.tests_spinner);
            viewPager = (ViewPager)FindViewById(Resource.Id.subject_test_viewPager);
        }

        protected override void OnStart()
        {
            if (SubjectsId.Length == 1)
            {
                spinner.Visibility = Android.Views.ViewStates.Invisible;
            }
            else
            {
                spinnerAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, SubjectsData.Instance.GetSubjectsTitle(SubjectsId));
                spinnerAdapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
                spinner.Adapter = spinnerAdapter;
                spinner.ItemSelected += Spinner_ItemSelected;
            }

            viewPagerAdapter = new TestsAdapter(SupportFragmentManager, TestsData.Instance.CurrentAnswers.Length, this);
            viewPager.Adapter = viewPagerAdapter;

            base.OnStart();
        }

        private void Spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            TestsData.Instance.LastPos[TestsData.Instance.CurrentId] = viewPager.CurrentItem;
            TestsData.Instance.CurrentId = e.Position;
            viewPagerAdapter.Update();
            viewPagerAdapter.NotifyDataSetChanged();
            viewPager.CurrentItem = TestsData.Instance.LastPos[e.Position];
        }

        protected override void OnDestroy()
        {
            TestsData.DeleteInstance();
            FragmentsWatcher.DeleteInstance();
            base.OnDestroy();
        }
    }
}