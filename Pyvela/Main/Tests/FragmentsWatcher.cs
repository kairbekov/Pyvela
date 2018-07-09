using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Support.V4.App;

namespace Pyvela.Main.Tests
{
    public class FragmentsWatcher
    {
        public static FragmentsWatcher Instance;
        public static void NewInstance()
        {
            if (Instance == null)
            {
                Instance = new FragmentsWatcher();
            }
        }
        public static void DeleteInstance()
        {
            Instance = null;
        }

        private List<TestsFragment> Container;

        protected FragmentsWatcher()
        {
            Container = new List<TestsFragment>();
        }

        public void Add(Fragment fragment)
        {
            Container.Add((TestsFragment)fragment);
        } 

        public void Remove(Fragment fragment)
        {

            if (Container.Contains((TestsFragment)fragment))
            {
                Container.Remove((TestsFragment)fragment);
            }
        }

        public TestsFragment[] Get()
        {
            return Container.ToArray();
        }
    }
}