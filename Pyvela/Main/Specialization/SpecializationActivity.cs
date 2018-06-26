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

namespace Pyvela.Main.Specialization
{
    [Activity(Label = "SpecializationActivity")]
    public class SpecializationActivity : Activity
    {
        TextView text1, text2, text3;
        Spinner spinner1, spinner2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.specialization_act);

            text1 = FindViewById<TextView>(Resource.Id.specializationTextView1);
            text2 = FindViewById<TextView>(Resource.Id.specializationTextView2);
            text3 = FindViewById<TextView>(Resource.Id.specializationTextView3);

            spinner1 = FindViewById<Spinner>(Resource.Id.specializationSpinner1);
            spinner2 = FindViewById<Spinner>(Resource.Id.specializationSpinner2);

            var item1 = new List<string>() {" Choose the subject"," Mathematics", " Biology", " Physic", " World History", " Geography", " Chemistry", " Right", " Foregion language",  " Literatura" };
            var item2 = new List<string>() {};
            



            

            var adapter1 = new ArrayAdapter<string>(this, Resource.Layout.spinner_markup, item1);
            adapter1.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner1.Adapter = adapter1;

            var adapter2 = new ArrayAdapter<string>(this, Resource.Layout.spinner_markup, item2);
            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner2.Adapter = adapter2;

            spinner1.ItemSelected += (sender, e) =>
            {
                var s = sender as Spinner;
                


                if (s.GetItemAtPosition(e.Position).ToString() == " Mathematics")
                {
                    adapter2.Clear();
                    adapter2.Add(" Physics");
                    adapter2.Add(" Geography");
                }
                else if (s.GetItemAtPosition(e.Position).ToString() ==" Physic" )
                {
                    adapter2.Clear();
                    adapter2.Add(" Mathematics");
                    adapter2.Add(" Chemistry");
                }
                else if (s.GetItemAtPosition(e.Position).ToString() == " Biology" )
                {
                    adapter2.Clear();
                    adapter2.Add(" Geography");
                    adapter2.Add(" Chemistry");
                }
                else if (s.GetItemAtPosition(e.Position).ToString() == " World History")
                {
                    adapter2.Clear();
                    adapter2.Add(" Literatura");
                    adapter2.Add(" Foregion Language");
                    adapter2.Add(" Geography");
                    adapter2.Add(" Right");
                }
                else if (s.GetItemAtPosition(e.Position).ToString() == " Geography")
                {
                    adapter2.Clear();
                    adapter2.Add(" Mathematics");
                    adapter2.Add(" Biology");
                    adapter2.Add(" World History");
                    adapter2.Add(" Forefion Language");
                }
                else if (s.GetItemAtPosition(e.Position).ToString() == " Chemistry")
                {
                    adapter2.Clear();
                    adapter2.Add(" Physics");
                    adapter2.Add(" Biology");
                }

                else if (s.GetItemAtPosition(e.Position).ToString() == " Right" || s.GetItemAtPosition(e.Position).ToString() == " Literatura")
                {
                    adapter2.Clear();
                    adapter2.Add(" World History");
                    
                }
                else if (s.GetItemAtPosition(e.Position).ToString() == " Foregion Language")
                {
                    adapter2.Clear();
                    adapter2.Add(" Geography");
                    adapter2.Add(" World History");
                }

            };
        }
    }
}