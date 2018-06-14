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

namespace Pyvela
{ [Activity(Label = "Pyvela" , Theme = "@android:style/Theme.Material.Light")]
    class Subject : Activity
    {
       
            private ListView lv;
            private CustomAdapter adapter;
            private JavaList<Spacecraft> spacecrafts;

            protected override void OnCreate(Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);

                SetContentView(Resource.Layout.ListViewc);

                lv = FindViewById<ListView>(Resource.Id.ListView);
               
                adapter = new CustomAdapter(this, GetSpacecrafts());

                lv.Adapter = adapter;

                lv.ItemClick += Lv_ItemClick;


            }


            void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
            {
                new AlertDialog.Builder(this).SetNegativeButton("Yes", (sender1, args) =>
                {

                })
                     .SetPositiveButton("No", (sender1, args) =>
                     {

                     })
         .SetMessage("Are you sure")
         .SetTitle("Exit")
         .Show();
            }


            /*Toast.MakeText(this, spacecrafts[e.Position].Name, ToastLength.Short).Show();

            */

            private JavaList<Spacecraft> GetSpacecrafts()
            {
                spacecrafts = new JavaList<Spacecraft>();

                Spacecraft s;

                s = new Spacecraft("Математика", Resource.Drawable.d);
                spacecrafts.Add(s);

                s = new Spacecraft("Физика", Resource.Drawable.c);
                spacecrafts.Add(s);

                s = new Spacecraft("Химия", Resource.Drawable.b);
                spacecrafts.Add(s);

                s = new Spacecraft("География", Resource.Drawable.a);
                spacecrafts.Add(s);

                s = new Spacecraft("Математикалық сауаттылық", Resource.Drawable.aaa);
                spacecrafts.Add(s);

                s = new Spacecraft("Қазақстан тарихы", Resource.Drawable.tarih);
                spacecrafts.Add(s);

                s = new Spacecraft("Оқу сауаттылығы", Resource.Drawable.book);
                spacecrafts.Add(s);

                s = new Spacecraft("Дүние жүзі тарихы", Resource.Drawable.ais);
                spacecrafts.Add(s);

                s = new Spacecraft("Ағылшын", Resource.Drawable.engl);
                spacecrafts.Add(s);

                s = new Spacecraft("Адам қоғам құқық", Resource.Drawable.chop);
                spacecrafts.Add(s);

                s = new Spacecraft("Биология", Resource.Drawable.byologia);
                spacecrafts.Add(s);

                return spacecrafts;

            }
        }
    }
