using System.Collections;
using System.Collections.Generic;
using Pyvela.Common.Containers;
namespace Pyvela.Data.Local
{
    public class TestsData
    {
        public static TestsData Instance { get; set; }             // Something
        public static void NewInstance(int[] SubjectId)
        {
            if (Instance == null)
            {
                Instance = new TestsData(SubjectId);
            }
        }         // like a 
        public static void DeleteInstance()
        {
            Instance = null;
        }                     // Singleton


        public int CurrentId { get; set; }                          // Current active subject's test
        public int[] CurrentAnswers
        {
            get { return SelectedAnswers[CurrentId]; }
            set { }
        }                              
        public int[] LastPos { get; set; }                          // User's position on subject tests
        public List<int[]> SelectedAnswers { get; set; }            // User's selected answers
        public int[] TestsPageCount { get; set; }                   // Counts of subjects test
        public  Exercise[] Exercises { get; set; }                  // Bundle of cards (question and answers)

        protected TestsData(int[] SubjectsId)
        {
            TestsPageCount = new int[SubjectsId.Length];
            Exercises = new Exercise[] {
            new Exercise("q1", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("q2", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("q3", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("q4", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("q5", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("q6", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
            new Exercise("qqqqqqqqqqq", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa", "aaaaaaaaaaa"),
        };

            SelectedAnswers = new List<int[]>();
            CurrentId = 0;
            if (SubjectsId.Length == 1)
            {
                LastPos = new int[1];
                int count = SubjectsId[0] < 4 ? 20 : 30;
                SelectedAnswers.Add(new int[count]);
            }
            else if (SubjectsId.Length == 2)
            {
                LastPos = new int[5];
                for (int i = 0; i < 3; i++)
                    SelectedAnswers.Add(new int[20]);
                for (int i = 0; i < 2; i++)
                SelectedAnswers.Add(new int[30]);
            }
            SelectedAnswers = SetDefaultValue(SelectedAnswers, -1);

        }
        private List<int[]> SetDefaultValue(List<int[]> list, int value)
        {
            foreach (int[] arr in list)
            {
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = value;
            }
            return list;
        }

    }
}