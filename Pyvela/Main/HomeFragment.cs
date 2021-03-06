﻿using Pyvela.Data.Local;
using Pyvela.Common.Containers;
using Pyvela.Common.Adapters;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Content;
using Pyvela.Main.Subjects;

namespace Pyvela.Main
{
    public class HomeFragment : Android.Support.V4.App.Fragment
    {
        private MainActivity Parent;

        public override void OnAttach(Context context)
        {
            Parent = (MainActivity)context;
            base.OnAttach(context);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            NavViewData.NewInstance();
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root =  inflater.Inflate(Resource.Layout.home_frag, container, false);
            GridView gridView = (GridView)root.FindViewById(Resource.Id.home_gridView);
            gridView.NumColumns = 2;
            gridView.Adapter = new GridViewAdapter(Parent, 4, ImageTitle.ConvertFrom(NavViewData.Instance.Titles,
                                                                                    NavViewData.Instance.Images));
            gridView.ItemClick += GridView_ItemClick;

            return root;
        }

        private void GridView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            switch (e.Position)
            {
                case 0:
                    Parent.ReplaceFragment(new ChooseSubjectsFragment());
                    return;
                case 1:
                    Parent.ReplaceFragment(new SubjectsFragment());
                    return;
            }
        }
    }
}