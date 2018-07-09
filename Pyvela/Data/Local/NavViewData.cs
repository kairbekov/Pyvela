using System;
using Pyvela.Common.Containers;
using System.Linq;

using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pyvela.Data.Local
{
    class NavViewData
    {
        private static Object mock = new Object();
        public static NavViewData Instance { get; set; }             // Something
        public static void NewInstance()                             // like a
        {
            if (Instance == null)
            {
                lock (mock)
                {
                    if (Instance == null)
                    {
                        Instance = new NavViewData();
                    }
                }
            }
        }
        public string[] Titles;
        public int[] Images;

        protected NavViewData()
        {
            Titles = new string[]
            {
                "UNT FULL", "UNT SINGLE", "EAEA FULL", "EAEA Single"
            };
            Images = new int[]
            {
                Resource.Drawable.icons_books,
                Resource.Drawable.icon_book,
                Resource.Drawable.icons_books,
                Resource.Drawable.icon_book
            };
        }
    }
}