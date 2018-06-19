﻿using System;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using System.Collections.Generic;

namespace Pyvela
{
    [Activity(Label = "Pyvela", Theme = "@style/AppTheme.NoActionBar", Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity, NavigationView.IOnNavigationItemSelectedListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main_activity);
            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(this, drawer, toolbar, Resource.String.navigation_drawer_open, Resource.String.navigation_drawer_close);
            drawer.AddDrawerListener(toggle);
            toggle.SyncState();

            NavigationView navigationView = FindViewById<NavigationView>(Resource.Id.nav_view);
            navigationView.SetNavigationItemSelectedListener(this);

            var fragmentTransaction = SupportFragmentManager.BeginTransaction();
            fragmentTransaction.Add(Resource.Id.content_main_fragments_placeholder, new NavDraw.Subjects.SubjectsFragment());
            fragmentTransaction.Commit();
        }

        public override void OnBackPressed()
        {
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            if (drawer.IsDrawerOpen(GravityCompat.Start))
            {
                drawer.CloseDrawer(GravityCompat.Start);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            var fragmentTransacion = SupportFragmentManager.BeginTransaction();

            int id = item.ItemId;

            if (id == Resource.Id.nav_main_page)
            {

            }
            else if (id == Resource.Id.nav_payment)
            {

            }
            else if (id == Resource.Id.nav_speciality)
            {

            }
            else if (id == Resource.Id.nav_UNT)
            {

            }
            else if (id == Resource.Id.nav_one_subject)
            {

            }
            else if (id == Resource.Id.nav_results)
            {
                fragmentTransacion.Replace(Resource.Id.content_main_fragments_placeholder, new NavDraw.Results.ResultsFragment());
            }
            else if (id == Resource.Id.nav_exit)
            {

            }
            else if (id == Resource.Id.nav_settings)
            {

            }
            fragmentTransacion.Commit();
            DrawerLayout drawer = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            drawer.CloseDrawer(GravityCompat.Start);
            return true;
        }
    }
}

