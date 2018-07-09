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

namespace Pyvela.Data.Local
{
    class SubjectsData
    {
        private static Object mock = new Object();
        public static SubjectsData Instance { get; set; }             // Something
        public static void NewInstance()                             // like a
        {
            if (Instance == null)
            {
                lock (mock)
                {
                    if (Instance == null)
                    {
                        Instance = new SubjectsData();

                    }
                }
            }
        }                            
        public static void DeleteInstance()                           // Singleton
        {
            Instance = null;
        }                        

        public string[] SubjectsTitle { get; set; }
        public int[] SubjectsImage { get; set; }

        protected SubjectsData()
        {
            SubjectsTitle = new string[]
            {
                "Mathematical literacy",
                "Reading Literacy",
                "History of Kazakhstan",
                "Math",
                "Physics",
                "Biology",
                "Chemistry",
                "Geography",
                "The World History",
                "Foreign language",
                "Human. Society. Right"
            };
            SubjectsImage = new int[]
            {
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
                Resource.Drawable.a,
            };
        }

        public string[] GetSubjectsTitle(int[] SubjectsId)
        {
            return new string[]
            {
                SubjectsTitle[0],
                SubjectsTitle[1],
                SubjectsTitle[2],
                SubjectsTitle[SubjectsId[0]],
                SubjectsTitle[SubjectsId[1]]
            };
        }
    }
}