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
        private int CardPos;
        private TextView Question;
        private Button[] Answers;
        private int SelectdAnswerPos
        {
            get
            {
                for (int i = 0; i < Answers.Length; i++)
                {
                    if (!Answers[i].Clickable) { return i; }
                }
                return -1;
            }
            set { }
        }

        public static TestsFragment NewInstanse(int pos)
        {
            Bundle bundle = new Bundle();
            bundle.PutInt(Args.QUESTION_POS, pos);
            var fragment = new TestsFragment
            {
                Arguments = bundle
            };
            return fragment;
        }

        public override void OnAttach(Context context)
        {
            base.OnAttach(context);
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            CardPos = Arguments.GetInt(Args.QUESTION_POS, 0);
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            //Inflate layout
            View root = inflater.Inflate(Resource.Layout.tests_frag, container, false);

            //Get views from root
            Question = (TextView)root.FindViewById(Resource.Id.tests_question);
            Answers = new Button[]
            {
                (Button)root.FindViewById(Resource.Id.tests_answer1),
                (Button)root.FindViewById(Resource.Id.tests_answer2),
                (Button)root.FindViewById(Resource.Id.tests_answer3),
                (Button)root.FindViewById(Resource.Id.tests_answer4),
                (Button)root.FindViewById(Resource.Id.tests_answer5),
            };

            //Get exercise from TestsData
            Exercise CardData = TestsData.Instance.Exercises[CardPos];

            //Set data for views
            Question.Text = CardData.Question;

            Button answer;
            for (int i = 0; i < Answers.Length; i++)
            {
                answer = Answers[i];
                answer.Text = CardData.Answer1;
                answer.Click += OnAnswerClick;
            }

            RestoreAnswersState(TestsData.Instance.CurrentAnswers[CardPos]);

            TextView PagePos = (TextView)root.FindViewById(Resource.Id.tests_pos);
            PagePos.Text = (CardPos + 1).ToString();

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
                }
                SelectedAnswer.Clickable = false;
                SelectedAnswer.SetBackgroundResource(Resource.Drawable.layout_bg_round2);
            }
        }

        public override void OnDestroy()
        {
            TestsData.Instance.CurrentAnswers[CardPos] = SelectdAnswerPos;
            FragmentsWatcher.Instance.Remove(this);
            base.OnDestroy();
        }

        public void Update()
        {
            int index = TestsData.Instance.CurrentAnswers[CardPos];
            RestoreAnswersState(index);
            Question.Text = "UPDATED";
        }

        private void RestoreAnswersState(int index)
        {
            foreach (Button answer in Answers)
            {
                if (!answer.Clickable)
                {
                    answer.Clickable = true;
                    answer.SetBackgroundResource(Resource.Drawable.layout_bg_round1);
                }
            }
            if (index != -1)
            {
                Answers[index].Clickable = false;
                Answers[index].SetBackgroundResource(Resource.Drawable.layout_bg_round2);
            }
        }
    }
}
    
