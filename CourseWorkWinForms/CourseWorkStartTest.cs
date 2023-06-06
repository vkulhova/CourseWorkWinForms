using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CourseWorkWinForms
{
    public partial class CourseWorkStartTest : Form
    {
        private Editor editor;
        private int counter = 0;
        private System.Windows.Forms.TextBox answerTextBox;


        public CourseWorkStartTest(Editor editor)
        {
            this.editor = editor;
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (editor.TestArr[0].QuestionsArr[counter] is DetailedAnswer)
            {
                if (counter > 0) 
                {
                    editor.TestArr[0].QuestionsArr[counter - 1].MarkOfQuestion(answerTextBox.Text);
                    editor.TestArr[0].ResultOfTest += editor.TestArr[0].QuestionsArr[counter - 1].Mark;
                }
                Controls.Clear();
                Label labelTestStartTestPage = new Label();
                labelTestStartTestPage.Font = new Font(labelTestStartTestPage.Font.FontFamily, 15);
                labelTestStartTestPage.Text = "Test";
                labelTestStartTestPage.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                labelTestStartTestPage.Location = new Point(17, 13);
                Controls.Add(labelTestStartTestPage);
                Label newLabelQuestionNum = new Label();
                newLabelQuestionNum.Location = new Point(labelTestStartTestPage.Location.X, labelTestStartTestPage.Bounds.Bottom + 10);
                newLabelQuestionNum.Text = "Question " + Convert.ToString(counter + 1);
                Controls.Add(newLabelQuestionNum);
                Label newLabelQuestionText = new Label();
                newLabelQuestionText.Location = new Point(newLabelQuestionNum.Location.X, newLabelQuestionNum.Bounds.Bottom + 5);
                newLabelQuestionText.Text = editor.TestArr[0].QuestionsArr[counter].QuestionText;
                Controls.Add(newLabelQuestionText);
                answerTextBox = new System.Windows.Forms.TextBox();
                answerTextBox.Location = new Point(newLabelQuestionText.Location.X, newLabelQuestionText.Bounds.Bottom + 10);
                answerTextBox.Size = new Size(400, Height);
                Controls.Add(answerTextBox);
                System.Windows.Forms.Button buttonStart = new System.Windows.Forms.Button();
                buttonStart.Location = new Point(answerTextBox.Location.X, answerTextBox.Bounds.Bottom);
                buttonStart.Text = "Next";
                Controls.Add(buttonStart);
                if (counter < editor.TestArr[0].QuestionsArr.Count - 1)
                {
                    counter++;
                    buttonStart.Click += buttonStart_Click;
                }
                else
                {
                    
                    buttonStart.Click += new EventHandler(buttonStart_Click1);
                    
                }
            }
            else if (editor.TestArr[0].QuestionsArr[counter] is OneRightVariantQuestion)
            {

            }
            else if (editor.TestArr[0].QuestionsArr[counter] is SomeRightVariantsQuestion)
            {

            }
        }

        private void buttonStart_Click1(object sender, EventArgs e)
        {
            editor.TestArr[0].QuestionsArr[counter].MarkOfQuestion(answerTextBox.Text);
            editor.TestArr[0].ResultOfTest += editor.TestArr[0].QuestionsArr[counter].Mark;
            MessageBox.Show("Congratulations! You have finished test.\nYou mark is " + Convert.ToString(editor.TestArr[0].ResultOfTest));
            this.Hide();
            CourseWorkStudentEditor courseWorkStudentEditor = new CourseWorkStudentEditor(editor);
            courseWorkStudentEditor.Show();
        }

    }

}
