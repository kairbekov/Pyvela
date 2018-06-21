using Android.Support.V4.App;
using Pyvela.NavDraw.Subjects;

using System;
namespace Pyvela.Utils.Adapters
{
    public class SubjectTestAdapter : FragmentPagerAdapter
    {
        public SubjectTestAdapter(FragmentManager fragementManager) : base(fragementManager)    
        {

        }

        public override int Count
        {
            get { return 5; }
        }

        public override Fragment GetItem(int position)
        {
            return SubjectTestFragment.NewInstanse(position);
        }
    }
}