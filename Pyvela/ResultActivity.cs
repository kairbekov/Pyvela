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
    [Activity(Label = "ResultActivity")]
    public class ResultActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ResultsPage);

            List<Containers.TableRow> Rows = new List<Containers.TableRow>
            {
                new Containers.TableRow("UNT", "12 April", "95/140"),
                new Containers.TableRow("UNT", "14 April", "98/140"),
                new Containers.TableRow("Math", "15 April", "24/30"),
                new Containers.TableRow("Physics", "12 April", "22/30"),
                new Containers.TableRow("KZ History", "12 April", "20/30")
            };

            ListView listView = FindViewById<ListView>(Resource.Id.ResultPageListView);
            listView.Adapter = new Adapters.TableAdapter(this, Resource.Layout.TableRowMarkup, Rows);
        }
    }
}