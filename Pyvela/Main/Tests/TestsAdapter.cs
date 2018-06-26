using Pyvela.Data.Local;
using Android.OS;
using Android.Support.V4.App;

namespace Pyvela.Main.Tests
{
    public class TestsAdapter : FragmentStatePagerAdapter
    {
        private int SubCount { get; set; }
        private int Order;

        public override int Count
        {
            get { return SubCount; }
        }

        public TestsAdapter(FragmentManager fragementManager, int ExercisesCount) : base(fragementManager)    
        {
            this.SubCount = ExercisesCount;
        }

        public override Fragment GetItem(int position)
        {
            return TestsFragment.NewInstanse(position);
        }
        public override IParcelable SaveState()
        {
            return base.SaveState();
        }
    }
}