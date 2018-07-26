using Pyvela.Main.Payments;
using Pyvela.Main.Results;
using Pyvela.Main.Subjects;
using Pyvela.Main;
using Android.App;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Content;
using Android.Preferences;

namespace Pyvela
{
    [Activity(Label = "Pyvela", Theme = "@style/AppTheme", Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        BottomNavigationView navigation;
        ProfileFragment profileFragment;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.main_activity);
            navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.NavigationItemSelected += Navigation_NavigationItemSelected;
            navigation.SelectedItemId = Resource.Id.nav_home;

            var fragmentTransaction = SupportFragmentManager.BeginTransaction();
            fragmentTransaction.Add(Resource.Id.main_content_fragments_placeholder, new HomeFragment());
            fragmentTransaction.SetTransition(4097);
            fragmentTransaction.Commit();

            profileFragment = new ProfileFragment();
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
                    fragmentTransaction.Replace(Resource.Id.main_content_fragments_placeholder, new SettingsFragment());
                    break;
            }
            fragmentTransaction.Commit();
        }
        public void ReplaceFragment(Android.Support.V4.App.Fragment fragment)
        {
            SupportFragmentManager.BeginTransaction()
                .Replace(Resource.Id.main_content_fragments_placeholder, fragment)
                .SetTransition(4097)
                .AddToBackStack(null)
                .Commit();
        }
    }
}

