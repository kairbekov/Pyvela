using Pyvela.Main.Payments;
using Pyvela.Main.Specialization;
using Pyvela.Main.Results;
using Pyvela.Main.Subjects;
using Pyvela.Main;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;

namespace Pyvela
{
    [Activity(Label = "Pyvela", Theme = "@style/AppTheme.NoActionBar", Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        BottomNavigationView navigation;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main_activity);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.NavigationItemSelected += Navigation_NavigationItemSelected;
            navigation.SelectedItemId = Resource.Id.nav_home;

            var fragmentTransaction = SupportFragmentManager.BeginTransaction();
            fragmentTransaction.Add(Resource.Id.main_content_fragments_placeholder, new HomeFragment());
            fragmentTransaction.SetTransition(4097);
            fragmentTransaction.Commit();
        }

        private void Navigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {

            if (navigation.SelectedItemId == e.Item.ItemId)
            {
                return;
            }

            var fragmentTransaction = SupportFragmentManager.BeginTransaction();
            switch (e.Item.ItemId)
            {
                case Resource.Id.nav_profile:
                    fragmentTransaction.Replace(Resource.Id.main_content_fragments_placeholder, new ProfileFragment());
                    break;
                case Resource.Id.nav_home:
                    fragmentTransaction.Replace(Resource.Id.main_content_fragments_placeholder, new HomeFragment());
                    break;
                case Resource.Id.nav_settings:
                    break;
            }
            fragmentTransaction.SetTransition(4097);
            fragmentTransaction.Commit();
        }
    }
}

