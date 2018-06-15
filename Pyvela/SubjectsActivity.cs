using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pyvela
{
    [Activity(Label = "SubjectsActivity")]
    public class SubjectsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SubjectsPage);

            List<Containers.ImageTitle> Subjects = new List<Containers.ImageTitle>
            {
                new Containers.ImageTitle("Mathematics", Resource.Drawable.d),
                new Containers.ImageTitle("Physics", Resource.Drawable.a),
                new Containers.ImageTitle("Geography", Resource.Drawable.aaa)
            };

            ListView listView = FindViewById<ListView>(Resource.Id.SubjectPageListView);
            listView.Adapter = new Adapters.ImageTitleAdapter(this, Resource.Layout.ImageTitleMarkup, Subjects);
        }
    }
}