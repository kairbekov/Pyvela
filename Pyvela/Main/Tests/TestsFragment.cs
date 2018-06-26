using Pyvela.Data.Local;
using Pyvela.Common.Containers;

using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Content;
using System;

namespace Pyvela.Main.Tests
{
    public class TestsFragment : Android.Support.V4.App.Fragment
    {
        private int mPos;
        private TestsActivity Parent;
        private TextView Question;
        private Button[] Answers;

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
            Parent = (TestsActivity)context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            mPos = Arguments.GetInt(Args.Tests.QUESTION_POS, 0);
        }

        public static TestsFragment NewInstanse(int pos)
        {
            Bundle bundle = new Bundle();
            bundle.PutInt(Args.Tests.QUESTION_POS, pos);
            var fragment = new TestsFragment
            {
                Arguments = bundle
            };
            return fragment;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View root =  inflater.Inflate(Resource.Layout.tests_frag, container, false);
            Answers = new Button[]
            {
                (Button)root.FindViewById(Resource.Id.tests_answer1),
                (Button)root.FindViewById(Resource.Id.tests_answer2),
                (Button)root.FindViewById(Resource.Id.tests_answer3),
                (Button)root.FindViewById(Resource.Id.tests_answer4),
                (Button)root.FindViewById(Resource.Id.tests_answer5),
            };

            Exercise exercise = SingleTest.Exercises[mPos];

            Question = (TextView)root.FindViewById(Resource.Id.tests_question);
            Question.Text = exercise.Question;

            Button answer;
            for ( int i = 0; i < Answers.Length; i++)
            {
                answer = Answers[i];
                answer.Text = exercise.Answer1;
                answer.Click += OnAnswerClick;
            }

            if (savedInstanceState != null)
            {
                int pos = savedInstanceState.GetInt(Args.Tests.SELECTED_ANSWER_POS);
                Answers[pos].Clickable = false;
                Answers[pos].SetBackgroundResource(Resource.Drawable.layout_bg_round2);
            }

            TextView PagePos = (TextView)root.FindViewById(Resource.Id.tests_pos);
            PagePos.Text = (mPos + 1).ToString();

            return root;
        }


        private void OnAnswerClick(object sender, EventArgs e)
        {
            Button SelectedAnswer = (Button)sender;
            
            if (SelectedAnswer.Clickable)
            {
                foreach (var answer in Answers)
                {
                    if (!answer.Clickable)
                        answer.Clickable = true;
                        answer.SetBackgroundResource(Resource.Drawable.layout_bg_round1);
                        break;
                }
                SelectedAnswer.Clickable = false;
                SelectedAnswer.SetBackgroundResource(Resource.Drawable.layout_bg_round2);
            }
        }

        public override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt(Args.Tests.SELECTED_ANSWER_POS, GetSelectedButtonPos());
            base.OnSaveInstanceState(outState);
        }

        public int GetSelectedButtonPos()
        {
            for (int i = 0; i < Answers.Length; i++)
            {
                if (Answers[i].Clickable)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}