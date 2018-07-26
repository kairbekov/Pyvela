using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Pyvela.Main
{
    public class ChooseSubjectsFragment : Android.Support.V4.App.Fragment
    {
        string[] strArr;
        string[] data;
        TextView Subject4;
        TextView Subject5;
        AlertDialog.Builder StartTest;
        AlertDialog.Builder SelectSubject;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            data = new string[] { "Mathematics Physics", "Biologya Chemistric", "Physics Chemistric" };
            View view = inflater.Inflate(Resource.Layout.choose_subjects_frag, container, false);

            Subject4 = (TextView)view.FindViewById(Resource.Id.textView4);
            Subject5 = (TextView)view.FindViewById(Resource.Id.textView5);
            ImageView Images = (ImageView)view.FindViewById(Resource.Id.imageView1);
            Button button = (Button)view.FindViewById(Resource.Id.button1);

            SelectSubject = new AlertDialog.Builder(Activity);
            SelectSubject.SetTitle("Subjects");
            SelectSubject.SetItems(data, OnClick);

            StartTest = new AlertDialog.Builder(Activity);
            StartTest.SetTitle("Warning");
            StartTest.SetMessage("Are you sure?");
            StartTest.SetNegativeButton("No", (sender, e) => { });
            StartTest.SetPositiveButton("Yes", (sender, e) => { });

            int image = Resource.Drawable.icons7;
            Images.SetImageResource(image);

            Images.Click += ClickImages;
            button.Click += StartClick;

            return view;
        }
        private void OnClick(object sender, DialogClickEventArgs e)
        {
            strArr = data[e.Which].Split(' ');

            Subject4.Text = "4." + strArr[0];
            Subject5.Text = "5." + strArr[1];
        }

        private void StartClick(object sender, EventArgs e)
        {
            StartTest.Show();
        }

        private void ClickImages(object sender, EventArgs e)
        {
            SelectSubject.Show();
        }
    }
}