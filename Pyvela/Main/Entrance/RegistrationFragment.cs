using System;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Pyvela.Main.Entrance
{
    public class RegistrationFragment : Android.Support.V4.App.Fragment
    {
        private EntranceActivity Parent;

        public override void OnAttach(Context context)
        {
            this.Parent = (EntranceActivity)context;
            base.OnAttach(context);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root = inflater.Inflate(Resource.Layout.reg_frag, container, false);
            root.FindViewById<Button>(Resource.Id.reg_sign_up).Click += RegSignupClick;
            return root;
        }

        private void RegSignupClick(object sender, EventArgs e)
        {
            Intent intent = new Intent(Parent, typeof(MainActivity));
            Parent.StartActivity(intent);
        }
    }
}