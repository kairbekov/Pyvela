using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace Pyvela
{
    class CustomAdapter : BaseAdapter
    {
        private readonly Context c;
        private readonly JavaList<Spacecraft> spacecrafts;
        private LayoutInflater inflater;


        public CustomAdapter(Context c, JavaList<Spacecraft> spacecrafts)
        {
            this.c = c;
            this.spacecrafts = spacecrafts;
        }


        public override Object GetItem(int position)
        {
            return spacecrafts.Get(position);
        }

        public override long GetItemId(int position)
        {
            return position;
        }



        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            if (inflater == null)
            {
                inflater = (LayoutInflater)c.GetSystemService(Context.LayoutInflaterService);
            }

            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.ListVIewa, parent, false);
            }

            CustomAdapterViewHolder holder = new CustomAdapterViewHolder(convertView)
            {
                NameTxt = { Text = spacecrafts[position].Name }
            };
            holder.Img.SetImageResource(spacecrafts[position].Image);


            return convertView;
        }


        public override int Count
        {
            get { return spacecrafts.Size(); }
        }
    }

    class CustomAdapterViewHolder : Java.Lang.Object
    {

        public TextView NameTxt;
        public ImageView Img;

        public CustomAdapterViewHolder(View itemView)
        {
            NameTxt = itemView.FindViewById<TextView>(Resource.Id.nameTxt);
            Img = itemView.FindViewById<ImageView>(Resource.Id.spacecraftImg);

        }
    }
}