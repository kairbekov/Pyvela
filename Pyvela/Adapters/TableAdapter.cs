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
    class TableAdapter: ArrayAdapter
    {
        private LayoutInflater Inflater { get; set; }
        private int Layout { get; set; } //Only TableRowMarkup
        private List<Pyvela.Containers.TableRow> Rows { get; set; }

        public TableAdapter(Context context, int Resourse, List<Pyvela.Containers.TableRow> Rows) : base(context, Resourse, Rows)
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

            Pyvela.Containers.TableRow Row = this.Rows[Position];

            TableColumn1.Text = (++Position).ToString();
            TableColumn2.Text = Row.Column2;
            TableColumn3.Text = Row.Column3;
            TableColumn4.Text = Row.Column4;

            return view;
        }
    }
}