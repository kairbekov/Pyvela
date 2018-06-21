using Pyvela.Data.Local;
using Pyvela.Utils.Containers;
using Android.OS;

using Android.Views;
using Android.Widget;

namespace Pyvela.NavDraw.Subjects
{
    public class SubjectTestFragment : Android.Support.V4.App.Fragment
    {
        private int mPos;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            mPos = Arguments.GetInt("question_pos", 0);
        }

        public static SubjectTestFragment NewInstanse(int pos)
        {
            Bundle bundle = new Bundle();
            bundle.PutInt("question_pos", pos);
            var fragment = new SubjectTestFragment
            {
                Arguments = bundle
            };
            return fragment;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root =  inflater.Inflate(Resource.Layout.subject_test_frag, container, false);

            TextView Question = (TextView)root.FindViewById(Resource.Id.subject_test_question);
            TextView Answer1 = (TextView)root.FindViewById(Resource.Id.subject_frag_answer1);
            TextView Answer2 = (TextView)root.FindViewById(Resource.Id.subject_frag_answer2);
            TextView Answer3 = (TextView)root.FindViewById(Resource.Id.subject_frag_answer3);
            TextView Answer4 = (TextView)root.FindViewById(Resource.Id.subject_frag_answer4);
            TextView Answer5 = (TextView)root.FindViewById(Resource.Id.subject_frag_answer5);

            Exercise exercise = SingleTest.Exercises[mPos];
             
            Question.Text = exercise.Question;
            Answer1.Text = exercise.Answer1;
            Answer2.Text = exercise.Answer2;
            Answer3.Text = exercise.Answer3;
            Answer4.Text = exercise.Answer4;
            Answer5.Text = exercise.Answer5;

            return root;
        }
    }
}