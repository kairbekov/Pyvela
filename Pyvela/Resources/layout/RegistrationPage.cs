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


namespace Pyvela
{ [Activity(Label = "Pyvela", MainLauncher = true, Icon = "@mipmap/icon")]
    class RegistrationPage : Activity
    {
            protected override void OnCreate(Bundle bundle)
            {
                base.OnCreate(bundle);

                SetContentView(Resource.Layout.RegistrationPage);

                EditText login = (EditText)FindViewById(Resource.Id.login);
                EditText password = (EditText)FindViewById(Resource.Id.password);
                EditText name = (EditText)FindViewById(Resource.Id.name);
                EditText surnames = (EditText)FindViewById(Resource.Id.surnames);
                EditText phone = (EditText)FindViewById(Resource.Id.phone);
                EditText email = (EditText)FindViewById(Resource.Id.email);

                Button button2 = FindViewById<Button>(Resource.Id.button2);
                Button button1 = FindViewById<Button>(Resource.Id.button1);

                button2.Click += (sender, e) =>
                {if (login.Text.Length == 0 || password.Text.Length == 0 || name.Text.Length == 0 || surnames.Text.Length == 0
                       || phone.Text.Length == 0 || email.Text.Length == 0)
                    {
                        Toast toast = Toast.MakeText(ApplicationContext,
             "Заполните все поля", ToastLength.Short);
                        toast.Show();
                    }
                    else if (password.Text.Length < 8)
                    {
                        Toast toast = Toast.MakeText(ApplicationContext,
              "Длина пароля 8 ", ToastLength.Short);
                        toast.Show();
                    }
                    else if (phone.Text.Length != 11)
                    {
                        Toast toast = Toast.MakeText(ApplicationContext,
                                   "Вы ввели неправильный номер", ToastLength.Short);
                        toast.Show();
                    }
                    else
                   {
                        var intent = new Intent(this, typeof(Subject));

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
    
