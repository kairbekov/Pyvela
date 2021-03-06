﻿using Pyvela.Common.Containers;

using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace Pyvela.Common.Adapters
{
    class ImageTitleAdapter : ArrayAdapter
    {
        private LayoutInflater Inflater { get; set; }
        private int Layout { get; set; } //Only ImageTitleMarkup
        private ImageTitle[] Subjects { get; set; }

        public ImageTitleAdapter(Context context, int Resourse, ImageTitle[] Subjects) : base(context, Resourse, Subjects)
        {
            this.Inflater = LayoutInflater.From(context);
            this.Layout = Resourse;
            this.Subjects = Subjects;
        }

        public override View GetView(int Position, View ConvertView, ViewGroup Parent)
        {
            View view = Inflater.Inflate(this.Layout, Parent, false);
            ImageView Image = (ImageView)view.FindViewById(Resource.Id.img_tl_image);
            TextView Title = (TextView)view.FindViewById(Resource.Id.img_tl_title);

            ImageTitle subject = this.Subjects[Position];

            Image.SetImageResource(subject.Image);
            Title.Text = subject.Title;

            return view;
        }

    }
}