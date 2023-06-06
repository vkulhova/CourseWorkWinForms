using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWinForms
{
    class DetailedAnswer : IQuestion
    {
        private string questionText = "";
        private int mark;
        private string textAnswer = "";
        private string userAnswer = "";

        public string TextAnswer
        {
            get
            {
                return textAnswer;
            }
            set
            {
                this.textAnswer = value;
            }
        }

        public string QuestionText
        {
            get
            {
                return this.questionText;
            }

            set
            {
                this.questionText = value;
            }
        }

        public int Mark
        {
            get
            {
                return this.mark;
            }

            set
            {
                this.mark = value;
            }
        }

        public string UserAnswer
        {
            get
            {
                return this.userAnswer;
            }
            set
            {
                this.userAnswer = value;
            }
        }

        public void MarkOfQuestion(string text)
        {
            UserAnswer = text;
            if (UserAnswer == TextAnswer)
            {
                Mark = 1;
            }
            else
            {
                Mark = 0;
            }
        }

        public void EnterVariants()
        {
            return;
        }

        public void EnterCorrectAnswers()
        {
            return;
        }

        public void ShowVariants()
        {
            return;
        }

        public void GetUserAnswer(string text)
        {
            UserAnswer = text;
        }
    }
}