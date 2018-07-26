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

namespace Pyvela.Data.Local
{
    class ImageChangeData
    {
        private static Object mock = new Object();
        public static ImageChangeData Instance { get; set; }
        public static void NewInstance()
        {
            if (Instance == null)
            {
                lock (mock)
                {
                    if (Instance == null)
                    {
                        Instance = new ImageChangeData();
                    }
                }
            }
        }
        public int[] Images;

        protected ImageChangeData()
        {
            Images = new int[]
            {
                Resource.Drawable.apotheosis,
                Resource.Drawable.the_Last_Day_of_Pompeii,
                Resource.Drawable.the_Ninth_Wave,
                Resource.Drawable.serow_Girl_with_Peaches,
                Resource.Drawable.morning_in_a_Pine_Forest
            };
        }
    }
}