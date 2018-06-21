using Pyvela.Utils.Adapters;
using Pyvela.Utils.Containers;

using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Pyvela.NavDraw.Payments
{
    public class PaymentsFragment : Android.Support.V4.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root = inflater.Inflate(Resource.Layout.payments_frag, container, false);

            List<Row> list = new List<Row>
            {
                new Row("----", "-----","----")
            };


            ListView listView = (ListView)root.FindViewById(Resource.Id.paymnets_frag_listView);
            listView.Adapter = new TableAdapter(Activity, Resource.Layout.table_markup, list);

            return root;
        }
    }
}