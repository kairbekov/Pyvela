using Pyvela.Main.Entrance;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace Pyvela.Main.Entrance
{
    [Activity(Label = "Pyvela",  Icon = "@mipmap/icon")]
    class RegistrationActivity : Activity   
    {
        protected override void OnCreate(Bundle bundle)
        {
            RequestWindowFeature(WindowFeatures.NoTitle);
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.registr_act);

            EditText login = (EditText)FindViewById(Resource.Id.login);
            EditText password1 = (EditText)FindViewById(Resource.Id.password1);
            EditText password2 = (EditText)FindViewById(Resource.Id.password2);
            EditText name = (EditText)FindViewById(Resource.Id.name);
            EditText surnames = (EditText)FindViewById(Resource.Id.surnames);
            EditText phone = (EditText)FindViewById(Resource.Id.phone);
            EditText email = (EditText)FindViewById(Resource.Id.email);

            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button1 = FindViewById<Button>(Resource.Id.button1);

            button2.Click += (sender, e) =>
            {
                if (login.Text.Length == 0 || password1.Text.Length == 0 || name.Text.Length == 0 ||
                    surnames.Text.Length == 0 || phone.Text.Length == 0 || email.Text.Length == 0)
                {
                    Toast toast = Toast.MakeText(ApplicationContext, "Заполните все поля", ToastLength.Short);
                    toast.Show();
                }
                else if (password1.Text.Length < 8)
                {
                    Toast toast = Toast.MakeText(ApplicationContext, "Длина пароля 8 ", ToastLength.Short);
                    toast.Show();
                }
                else if (password1.Text != password2.Text)
                {
                    Toast toast = Toast.MakeText(ApplicationContext, "Пароли не совпадают ", ToastLength.Short);
                    toast.Show();

                }
                else if (phone.Text.Length != 11)
                {
                    Toast toast = Toast.MakeText(ApplicationContext, "Вы ввели неправильный номер", ToastLength.Short);
                    toast.Show();
                }
                else
                {
                    var intent = new Intent(this, typeof(MainActivity));
                    this.StartActivity(intent);
                }
            };

            button1.Click += (sender1, e) =>
            {
                var intent = new Intent(this, typeof(AuthorizationActivity));
                StartActivity(intent);
            };

        }
    }
}
    
