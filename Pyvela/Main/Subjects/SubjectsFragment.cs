using Pyvela.Common.Containers;
using Pyvela.Common.Adapters;
using Pyvela.Main.Tests;
using Pyvela.Data.Local;

using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Content;

using System.Collections.Generic;

namespace Pyvela.Main.Subjects
{
    public class SubjectsFragment : Android.Support.V4.App.Fragment
    {
        private ListView listView;

        public override void OnCreate(Bundle savedInstanceState)
        {
            SubjectsData.NewInstance();
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root =  inflater.Inflate(Resource.Layout.subjects_frag, container, false);
            listView = (ListView)root.FindViewById(Resource.Id.subjects_frag_listView);
            ImageView image = (ImageView)root.FindViewById(Resource.Id.img_tl_image);
            TextView title = (TextView)root.FindViewById(Resource.Id.img_tl_title);

            return root;
        }
        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            listView.ItemClick += On_ItemClick;
            listView.Adapter = new ImageTitleAdapter(Activity, Resource.Layout.image_title_markup, GetImageTitles());

            base.OnActivityCreated(savedInstanceState);
        }

        public override void OnDestroy()
        {
            SubjectsData.DeleteInstance();
            base.OnDestroy();
        }

        private void On_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(Activity, typeof(TestsActivity));
            intent.PutExtra(Args.SUBJECTS_ID, new int[2] {5, 6});
            Activity.StartActivity(intent);
        }

        private ImageTitle[] GetImageTitles()
        {
            return ImageTitle.ConvertFrom(SubjectsData.Instance.SubjectsTitle, SubjectsData.Instance.SubjectsImage);
        }
    }
}