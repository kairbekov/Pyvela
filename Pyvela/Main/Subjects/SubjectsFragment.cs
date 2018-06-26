using System.Collections.Generic;
using Pyvela.Common.Containers;
using Pyvela.Common.Adapters;
using Pyvela.Main.Tests;

using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Content;

namespace Pyvela.Main.Subjects
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
            ImageView image = (ImageView)root.FindViewById(Resource.Id.img_tl_image);
            TextView title = (TextView)root.FindViewById(Resource.Id.img_tl_title);

            lv.ItemClick += On_ItemClick;

            List<ImageTitle> imgTitle = new List<ImageTitle>()
            {
                new ImageTitle("Mathematical literacy", Resource.Drawable.a),
                new ImageTitle("Reading Literacy", Resource.Drawable.a),
                new ImageTitle("History of Kazakhstan", Resource.Drawable.a),
                new ImageTitle("Math", Resource.Drawable.a),
                new ImageTitle("Physics", Resource.Drawable.a),
                new ImageTitle("Biology", Resource.Drawable.a),
                new ImageTitle("Chemistry", Resource.Drawable.a),
                new ImageTitle("Geography", Resource.Drawable.a),
                new ImageTitle("The World History", Resource.Drawable.a),
                new ImageTitle("Foreign language", Resource.Drawable.a),
                new ImageTitle("Human. Society. Right", Resource.Drawable.a),
            };
            lv.Adapter = new ImageTitleAdapter(Activity, Resource.Layout.image_title_markup, imgTitle);

            return root;
        }

        private void On_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(Activity, typeof(TestsActivity));
            intent.PutExtra(Args.Subjects.SUBJECT_POSITION, e.Position);
            intent.PutExtra(Args.Tests.TEST_MODE, Args.Tests.Single);
            Activity.StartActivity(intent); 
        }

    }
}