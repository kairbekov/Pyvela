namespace Pyvela
{
    class Args
    {
        public partial class Tests
        {
            public const int Single = 1;
            public const int Specialities = 2;
            public const int Unt = 3;

            public const string TEST_MODE = "tm";
            public const string SINGLE_SUBJECT_COUNT = "ssc";
            public const string QUESTION_POS = "qp";
            public const string SELECTED_ANSWER_POS = "swp";
        }

        public partial class Subjects
        {
            public const string SUBJECT_POSITION = "sp";

            string[] Items = new string[] { "Mathematical literacy",
                                            "Reading Literacy",
                                            "History of Kazakhstan",
                                            "Math",
                                            };
        }
    }
}