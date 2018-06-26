using Pyvela.Data.Local;

using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V4.View;
using Android.Widget;

namespace Pyvela.Main.Tests
{
    [Activity(Label = "TestActivity")]
    public class TestsActivity : Android.Support.V4.App.FragmentActivity
    {
        ViewPager viewPager;
        Spinner spinner;
        private int TestsMode;
        private TestsAdapter[] Adapters;
        private string[] spinnerList;

        protected override void OnCreate(Bundle savedInstanceState)
        {   
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.tests_act);

            TestsMode = Intent.GetIntExtra(Args.Tests.TEST_MODE, 0);

            if (TestsMode == Args.Tests.Single)
            {
                int SubjectPosition = Intent.GetIntExtra(Args.Subjects.SUBJECT_POSITION, 0);
                int ExercisesCount;

                if (SubjectPosition <= 2)
                    ExercisesCount = 20;
                else
                    ExercisesCount = 30;
                viewPager = (ViewPager)FindViewById(Resource.Id.subject_test_viewPager);
                viewPager.Adapter = new TestsAdapter(SupportFragmentManager, ExercisesCount);
                //TestsData.Add(new List<string>());
                
                spinner = (Spinner)FindViewById(Resource.Id.tests_spinner);
                spinner.Visibility = Android.Views.ViewStates.Invisible;
            }
            else if (TestsMode == Args.Tests.Specialities)
            {
                Adapters = new TestsAdapter[]
                {
                    new TestsAdapter(SupportFragmentManager, 30),
                    new TestsAdapter(SupportFragmentManager, 30)
                };
                spinnerList = new string[] { };
            }
            else if (TestsMode == Args.Tests.Unt)
            {
                Adapters = new TestsAdapter[]
                {
                    new TestsAdapter(SupportFragmentManager, 20),
                    new TestsAdapter(SupportFragmentManager, 20),
                    new TestsAdapter(SupportFragmentManager, 20),
                    new TestsAdapter(SupportFragmentManager, 30),
                    new TestsAdapter(SupportFragmentManager, 30)
                };
            }
            else
            {

            }

            
            //spinner.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerItem, )


        }

        public void SwitchAdapter(int pos)
        {
            viewPager.Adapter = Adapters[pos];
        }
    }
}