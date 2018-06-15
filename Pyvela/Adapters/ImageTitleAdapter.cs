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

namespace Pyvela.Adapters
{
    class ImageTitleAdapter : ArrayAdapter
    {
        private LayoutInflater Inflater { get; set; }
        private int Layout { get; set; } //Only ImageTitleMarkup
        private List<Containers.ImageTitle> Subjects { get; set; }

        public ImageTitleAdapter(Context context, int Resourse, List<Containers.ImageTitle> Subjects) : base(context, Resourse, Subjects)
        {
            this.Inflater = LayoutInflater.From(context);
            this.Layout = Resourse;
            this.Subjects = Subjects;
        }

        public override View GetView(int Position, View ConvertView, ViewGroup Parent)
        {
            View view = Inflater.Inflate(this.Layout, Parent, false);
            ImageView Image = (ImageView)view.FindViewById(Resource.Id.ImageTitleMarkupImage);
            TextView Title = (TextView)view.FindViewById(Resource.Id.ImageTitleMarkupTitle);

            Containers.ImageTitle subject = this.Subjects[Position];

            Image.SetImageResource(subject.Image);
            Title.Text = subject.Title;

            return view;
        }
    }
}