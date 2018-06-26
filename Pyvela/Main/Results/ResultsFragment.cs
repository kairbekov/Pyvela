using Pyvela.Common.Adapters;
using Pyvela.Common.Containers;

using System.Collections.Generic;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Pyvela.Main.Results
{
    public class ResultsFragment : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root = inflater.Inflate(Resource.Layout.results_frag, container, false);

            List<Row> rows = new List<Row> {
                                                new Row("Test", "Date", "Points"),
                                                new Row("Test", "Date", "Points"),
                                                new Row("Test", "Date", "Points"),
                                                new Row("Test", "Date", "Points"),
                                                new Row("Test", "Date", "Points")
                                              };

            ListView lv = (ListView)root.FindViewById(Resource.Id.results_frag_listView);
            lv.Adapter = new TableAdapter(Activity, Resource.Layout.table_markup, rows);
            return root;
        }
    }
}