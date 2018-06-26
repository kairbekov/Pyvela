using System.Collections.Generic;
using Pyvela.Common.Containers;
namespace Pyvela.Data.Local
{
    public class TestsData
    {
        private static List<List<int>> SelectedAnswers = new List<List<int>>();

        private string[] SubjectsTitle = new string[]
        {
            
        }

        public static void AddSelectedAnswer(int subjecTitle, int answerIndex, int value)
        {
            int subjectIndex = GetSubjectId(subjecTitle);
            (SelectedAnswers[subjectIndex])[answerIndex] = value;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        }
        public static int GetSelectedAnswer(int subjectTitle, int answerIndex)
        {
            return (SelectedAnswers[subjectIndex])[answerIndex];
        }

        public static Exercise GetExercise(int subjectIndex, int answerIndex)
        {

        }

        public static GetSubjectId(string subjectTitle)
        {
            
        }
    }
}