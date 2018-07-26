using System;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Views;
using Android.Widget;
using Pyvela.Data.Local;

namespace Pyvela.Main
{
    public class ProfileFragment : Android.Support.V4.App.Fragment
    {
        private ImageView imageView;
        private TextView textView;
        private MainActivity Parent;
        private Button button;
        private ISharedPreferences SharedPrefs;
        private ISharedPreferencesEditor PrefsEditor;
        private Context mContext;
        private int integer;

        public override void OnAttach(Context context)
        {
            this.Parent = (MainActivity)context;
            base.OnAttach(context);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            ImageChangeData.NewInstance();
            mContext = Activity;
            SharedPrefs = PreferenceManager.GetDefaultSharedPreferences(mContext);
            integer = SharedPrefs.GetInt("Image", 1);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root = inflater.Inflate(Resource.Layout.profile_frag, container, false);
            
            imageView = root.FindViewById<ImageView>(Resource.Id.profile_image);
            button = root.FindViewById<Button>(Resource.Id.profile_button);
            
            var images = ImageChangeData.Instance.Images;
            imageView.SetImageResource(images[integer]);
            imageView.Click += ImageView_Click;
            return root;
        }

        private void ImageView_Click(object sender, EventArgs e)
        {
            Parent.ReplaceFragment(new ImageChangeFragment());
        }
    }
}