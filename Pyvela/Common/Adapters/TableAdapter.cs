﻿using Pyvela.Common.Containers;

using System.Collections.Generic;

using Android.Content;
using Android.Views;
using Android.Widget;

namespace Pyvela.Common.Adapters
{
        class TableAdapter: ArrayAdapter
        {
            private LayoutInflater Inflater { get; set; }
            private int Layout { get; set; } //Only table_markup
            public List<Row> Rows { get; set; }

            public TableAdapter(Context context, int Resourse, List<Row> Rows) : base(context, Resourse, Rows)
            {
                this.Inflater = LayoutInflater.From(context);
                this.Layout = Resourse;
                this.Rows = Rows;
            }

            public override View GetView(int Position, View ConvertView, ViewGroup Parent)
            {
                View view = Inflater.Inflate(this.Layout, Parent, false);
                TextView TableColumn1 = (TextView)view.FindViewById(Resource.Id.table_markup_column1);
                TextView TableColumn2 = (TextView)view.FindViewById(Resource.Id.table_markup_column2);
                TextView TableColumn3 = (TextView)view.FindViewById(Resource.Id.table_markup_column3);
                TextView TableColumn4 = (TextView)view.FindViewById(Resource.Id.table_markup_column4);

                Row row = this.Rows[Position];

                TableColumn1.Text = (++Position).ToString();
                TableColumn2.Text = row.Column2;
                TableColumn3.Text = row.Column3;
                TableColumn4.Text = row.Column4;

                return view;
            }

            public override void NotifyDataSetChanged()
            {
                base.NotifyDataSetChanged();
            }
        }
}