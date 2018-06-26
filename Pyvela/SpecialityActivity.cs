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
{
    [Activity(Label = "SpecialitiesActivity")]
    public class SpecialityActivity : Activity
    {
        TextView text, text1, text2;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.speciality_act);
            text = FindViewById<TextView>(Resource.Id.textView1);
            text1 = FindViewById<TextView>(Resource.Id.textView2);
            text2 = FindViewById<TextView>(Resource.Id.textView3);

            var item1 = new List<string>() { " Choose", " Mathematics", " Biology", " Physics", " World History", " Geography", " Chemistry", " Right" };
            var item2 = new List<string>() { " Choose", " Mathematics", " Biology", " Physics", " World History", " Geography", " Chemistry", " Right" };
            var speciality = new List<string>() { "Choose specialaty", "VTiPO", "Doctor", "Economy" };
            var storage1 = new List<string>() { };
            var storage2 = new List<string>() { };

            Spinner spinner1 = FindViewById<Spinner>(Resource.Id.spinner1);
            Spinner spinner2 = FindViewById<Spinner>(Resource.Id.spinner2);
            Spinner spinner3 = FindViewById<Spinner>(Resource.Id.spinner3);


            var adapter1 = new ArrayAdapter<string>(this, Resource.Layout.spinner_markup, item1);
            adapter1.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner1.Adapter = adapter1;



            /*spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_ItemSelected);
            var adapter = ArrayAdapter.CreateFromResource(
                    this, Resource.Array.subject_array, Resource.Layout.spinner_item);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner.Adapter = adapter;*/

            var adapter2 = new ArrayAdapter<string>(this, Resource.Layout.spinner_markup, item2);
            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinner2.Adapter = adapter2;

            var adapter3 = new ArrayAdapter<string>(this, Resource.Layout.spinner_markup, speciality);
            adapter2.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);

            spinner3.Adapter = adapter3;

            //int a = 0;
            //string b = "f";
            spinner1.ItemSelected += (sender, e) =>
            {
                var s = sender as Spinner;


                /*for (int i = 1; i < item1.Count; i++)
                { 
                    
                    if (s.GetItemAtPosition(e.Position).ToString() == item1[i])
                    {
                        adapter2.Remove(item1[i]);
                        b = item1[i];
                        storage1.Add(b);
                        
                    }
                    
                    
                }
                if (a >1)
                {
                    adapter2.Add(storage1[0]);
                }
                a++;
                if (storage1.Count > 2)
                    storage1.RemoveAt(0);*/
            };

            //int c = 0;
            //string d = "";
            spinner2.ItemSelected += (sender, e) =>
            {
                var s = sender as Spinner;


                /*for (int j = 1; j < item2.Count; j++)
                {

                    if (s.GetItemAtPosition(e.Position).ToString() == item2[j])
                    {
                        adapter1.Remove(item2[j]);
                        d = item2[j];
                        storage2.Add(d);
                    }
                    
                }
                if (c >1)
                {
                    adapter1.Add(storage2[0]);
                }
                c++;
                if (storage2.Count > 1)
                    storage2.RemoveAt(0);*/
            };

            spinner3.ItemSelected += (sender, e) =>
            {
                var s = sender as Spinner;
                for (int i = 1; i < speciality.Count; i++)
                {

                    if (s.GetItemAtPosition(e.Position).ToString() == "VTiPO")
                    {
                        spinner1.SetSelection(item1.IndexOf(" Mathematics"));
                        spinner2.SetSelection(item2.IndexOf(" Physics"));
                    }
                    else if (s.GetItemAtPosition(e.Position).ToString() == "Doctor")
                    {
                        spinner1.SetSelection(item1.IndexOf(" Biology"));
                        spinner2.SetSelection(item2.IndexOf(" Chemistry"));
                    }
                    else if (s.GetItemAtPosition(e.Position).ToString() == "Economy")
                    {
                        spinner1.SetSelection(item1.IndexOf(" Mathematics"));
                        spinner2.SetSelection(item2.IndexOf(" Geography"));
                    }

                }
            };
        }
    }
}