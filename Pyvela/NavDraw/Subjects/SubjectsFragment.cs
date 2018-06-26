using System;
using System.Collections.Generic;
using System.Linq;
using Pyvela.Utils.Containers;
using Pyvela.Utils.Adapters;

using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Content;

namespace Pyvela.NavDraw.Subjects
{
    public class SubjectsFragment : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root =  inflater.Inflate(Resource.Layout.subjects_frag, container, false);
            ListView lv = (ListView)root.FindViewById(Resource.Id.subjects_frag_listView);
            ImageView image = (ImageView)Activity.FindViewById(Resource.Id.img_tl_image);
            TextView title = (TextView)Activity.FindViewById(Resource.Id.img_tl_title);

            lv.ItemClick += On_ItemClick;

            List<ImageTitle> imgTitle = new List<ImageTitle>
            {
                new ImageTitle("Title", Resource.Drawable.a),
                new ImageTitle("Title", Resource.Drawable.aaa)
            };
            lv.Adapter = new ImageTitleAdapter(Activity, Resource.Layout.image_title_markup, imgTitle);

            return root;
        }

        private void On_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(Activity, typeof(SubjectTestActivity));
            Activity.StartActivity(intent);
        }

    }
}