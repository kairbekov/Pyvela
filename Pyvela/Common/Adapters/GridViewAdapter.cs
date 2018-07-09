using Pyvela.Common.Containers;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Pyvela.Common.Adapters
{
    class GridViewAdapter : BaseAdapter
    {
        public int SubCount { get; set; }
        private Context context { get; set; }
        private ImageTitle[] ImageTitles { get; set; }

        public override int Count
        {
            get { return SubCount; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
            {
                LayoutInflater layoutInflater = LayoutInflater.From(context);
                convertView = layoutInflater.Inflate(Resource.Layout.grid_view_item, null);
            }
            ImageTitle imageTitle = ImageTitles[position];
            ImageView image = convertView.FindViewById<ImageView>(Resource.Id.grid_view_image);
            TextView text = convertView.FindViewById<TextView>(Resource.Id.grid_view_text);
            image.SetImageResource(imageTitle.Image);
            text.Text = imageTitle.Title;

            return convertView;
        }

        public GridViewAdapter(Context context, int Count, ImageTitle[] ImageTitles)
        {
            this.context = context;
            this.SubCount = Count;
            this.ImageTitles = ImageTitles;
        }
    }
}