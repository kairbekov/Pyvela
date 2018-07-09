using Pyvela.Data.Local;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Java.Lang;

namespace Pyvela.Main.Tests
{
    public class TestsAdapter : FragmentStatePagerAdapter
    {
        public int SubCount { get; set; }
        public TestsActivity Parent { get; set; }

        public override int Count
        {
            get { return SubCount; }
        }

        public TestsAdapter(FragmentManager fragementManager, int subCount, TestsActivity Parent) : base(fragementManager)    
        {
            this.SubCount = subCount;
            this.Parent = Parent;
        }

        public override Fragment GetItem(int position)
        {
            var fragment = TestsFragment.NewInstanse(position);
            FragmentsWatcher.Instance.Add(fragment);
            return fragment;
        }
        public void Update()
        {
            foreach (TestsFragment fragment in FragmentsWatcher.Instance.Get())
            {
                fragment.Update();
            }
        }
    }
}