using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Pyvela.Common.Adapters;

namespace Pyvela.Main
{
    public class ImageChangeFragment : Android.Support.V4.App.Fragment
    {
        private ISharedPreferences SharedPrefs;
        private ISharedPreferencesEditor PrefsEditor;
        private Context mContext;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root = inflater.Inflate(Resource.Layout.image_change_frag, container, false);
            GridView gridView = root.FindViewById<GridView>(Resource.Id.image_change_gridview);
            gridView.Adapter = new ImageChangeAdapter(Activity);
            
            gridView.ItemClick += GridView_ItemClick;
            
            return root;
        }

        private void GridView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            mContext = Activity;
            SharedPrefs = PreferenceManager.GetDefaultSharedPreferences(mContext);
            PrefsEditor = SharedPrefs.Edit();
            switch (e.Position)
            {
                case 0:
                    PrefsEditor.PutInt("Image",0);
                    PrefsEditor.Commit();
                    break;
                case 1:
                    PrefsEditor.PutInt("Image", 1);
                    PrefsEditor.Commit();
                    break;
                case 2:
                    PrefsEditor.PutInt("Image", 2);
                    PrefsEditor.Commit();
                    break;
            }
        }
    }
}