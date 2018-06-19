using Pyvela.Utils.Containers;

using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;

namespace Pyvela.Utils.Adapters
{
    class TableAdapter: ArrayAdapter
    {
        private LayoutInflater Inflater { get; set; }
        private int Layout { get; set; } //Only table_markup
        private List<Row> Rows { get; set; }

        public TableAdapter(Context context, int Resourse, List<Row> Rows) : base(context, Resourse, Rows)
        {
            this.Inflater = LayoutInflater.From(context);
            this.Layout = Resourse;
            this.Rows = Rows;
        }

        public override View GetView(int Position, View ConvertView, ViewGroup Parent)
        {
            View view = Inflater.Inflate(this.Layout, Parent, false);
            TextView TableColumn1 = (TextView)view.FindViewById(Resource.Id.TableRowMarkupColumn1);
            TextView TableColumn2 = (TextView)view.FindViewById(Resource.Id.TableRowMarkupColumn2);
            TextView TableColumn3 = (TextView)view.FindViewById(Resource.Id.TableRowMarkupColumn3);
            TextView TableColumn4 = (TextView)view.FindViewById(Resource.Id.TableRowMarkupColumn4);

            Row row = this.Rows[Position];

            TableColumn1.Text = (++Position).ToString();
            TableColumn2.Text = row.Column2;
            TableColumn3.Text = row.Column3;
            TableColumn4.Text = row.Column4;

            return view;
        }
    }
}