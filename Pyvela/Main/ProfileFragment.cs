using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Pyvela.Main
{
    public class ProfileFragment : Android.Support.V4.App.Fragment
    {
        private ImageView imageView;
        private TextView textView;
        private MainActivity Parent;
        private Button button;

        public override void OnAttach(Context context)
        {
            Console.WriteLine("On Attach");
            this.Parent = (MainActivity)context;
            base.OnAttach(context);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            Console.WriteLine("On Create View");
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Console.WriteLine("On Create View");
            View root = inflater.Inflate(Resource.Layout.profile_frag, container, false);

            imageView = root.FindViewById<ImageView>(Resource.Id.profile_image);
            button = root.FindViewById<Button>(Resource.Id.profile_button);
            button.Click += Button_Click;
            return root;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            button.Text = "LOL KEK";
            imageView.SetImageResource(Resource.Drawable.a);
        }
    }
}