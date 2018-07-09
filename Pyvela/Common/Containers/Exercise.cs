using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Pyvela.Common.Containers
{
    public class Exercise
    {
        public string Question { get;}
        public string Answer1 { get; }
        public string Answer2 { get; }
        public string Answer3 { get; }
        public string Answer4 { get; }
        public string Answer5 { get; }

        public Exercise(string question, string answer1, string answer2,
                        string answer3, string answer4, string answer5)
        {
            this.Question = question;
            this.Answer1 = answer1;
            this.Answer2 = answer2;
            this.Answer3 = answer3;
            this.Answer4 = answer3;
            this.Answer5 = answer5;
        }
    }
}