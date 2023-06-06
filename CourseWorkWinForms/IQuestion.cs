using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWinForms
{

    public interface IQuestion
    {
        void MarkOfQuestion(string text);

        void ShowVariants();

        void EnterVariants();

        void EnterCorrectAnswers();

        void GetUserAnswer(string text);

        string QuestionText
        { get; set; }

        int Mark
        { get; set; }
    }

}