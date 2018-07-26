using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Pyvela.Data.Local;

namespace Pyvela.Common.Adapters
{
    class ImageChangeAdapter : BaseAdapter
    {
        Context context;

        public ImageChangeAdapter(Context context)
        {
            this.context = context;
            ImageChangeData.NewInstance();
        }

        public override int Count
        {
            get
            {
                return 5;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var images = ImageChangeData.Instance.Images;

            ImageView imageView;

            if (convertView == null)
            {
                imageView = new ImageView(context);
                imageView.LayoutParameters = new GridView.LayoutParams(200, 200);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(8, 8, 8, 8);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(images[position]);
            return imageView;
        }
       
    }
}