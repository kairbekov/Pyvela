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

namespace Pyvela.Main.Entrance
{
    public class AuthorizationFragment : Android.Support.V4.App.Fragment
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
            View root = inflater.Inflate(Resource.Layout.auth_frag, container, false);
            root.FindViewById<Button>(Resource.Id.auth_sign_in).Click += AuthSignInClick;
        
            return root;
        }

        private void AuthSignInClick(object sender, EventArgs e)
        {
            Parent.ReplaceFragment(new RegistrationFragment());
        }
    }
}