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

namespace CourseWorkWinForms
{
    public partial class CourseWorkAddTest : Form
    {
        private Editor editor;
        private System.Windows.Forms.Button newButton;
        private Label newLabelCount;
        private Label newLabelCount1;
        private System.Windows.Forms.TextBox newTextBoxCount;
        private System.Windows.Forms.TextBox newTextBoxCount1;
        private System.Windows.Forms.Button newButton1;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.TextBox newTextBox1;
        private System.Windows.Forms.TextBox newTextBox2;
        private System.Windows.Forms.TextBox newTextBox3;
        private System.Windows.Forms.TextBox newTextBox4;
        private System.Windows.Forms.Button newButton2;
        private System.Windows.Forms.Button newButton4;
        private System.Windows.Forms.Button newButton5;
        private System.Windows.Forms.Button newButton6;
        private System.Windows.Forms.Button newButton8;
        private System.Windows.Forms.Button newButtonFinish;
        private Test test = new Test();
        private OneRightVariantQuestion questionOV;
        private SomeRightVariantsQuestion questionSV;

        private int questionCount = 1;
        private int CountOfVariants;
        private int counter = 1;
        public CourseWorkAddTest(Editor editor)
        {
            InitializeComponent();
            InitializeOptions();
            this.editor = editor;
        }

        private void InitializeOptions()
        {
            comboBoxAddTestPage1.Items.Add("Text answer question");
            comboBoxAddTestPage1.Items.Add("One variant question");
            comboBoxAddTestPage1.Items.Add("Some variants question");
        }
        private void comboBoxAddTestPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboBoxAddTestPage1.SelectedItem.ToString();
            if (selectedOption == "Text answer question")
            {
                Controls.Remove(comboBoxAddTestPage1);
                Controls.Remove(newButtonFinish);
                Label newLabel1 = new Label();
                newLabel1.Text = "Question " + questionCount.ToString();
                newLabel1.Location = new Point(labelTestAddTestPage.Location.X, labelTestAddTestPage.Bounds.Bottom + 10); ;
                Controls.Add(newLabel1);
                newTextBox = new System.Windows.Forms.TextBox();
                newTextBox.Size = new Size(400, 39);
                newTextBox.Location = new Point(newLabel1.Location.X, newLabel1.Bounds.Bottom);
                Controls.Add(newTextBox);
                Label newLabel = new Label();
                newLabel.Size = new Size(400, newLabel.Size.Height);
                newLabel.Text = "Enter answer for this question";
                newLabel.Location = new Point(newTextBox.Location.X, newTextBox.Bounds.Bottom + 10);
                Controls.Add(newLabel);
                newTextBox1 = new System.Windows.Forms.TextBox();
                newTextBox1.Size = new Size(400, 39);
                newTextBox1.Location = new Point(newTextBox.Location.X, newLabel.Bounds.Bottom);
                Controls.Add(newTextBox1);
                newButton = new System.Windows.Forms.Button();
                newButton.Text = "Next";
                newButton.Location = new Point(newTextBox.Location.X, newTextBox1.Bounds.Bottom + 10);
                Controls.Add(newButton);
                newButton.Click += new EventHandler(newButton_Click);
                questionCount++;
            }
            else if (selectedOption == "One variant question")
            {
                Controls.Remove(newButtonFinish);
                Controls.Remove(comboBoxAddTestPage1);
                Label newLabel1 = new Label();
                newLabel1.Text = "Question " + questionCount.ToString();
                newLabel1.Location = new Point(labelTestAddTestPage.Location.X, labelTestAddTestPage.Bounds.Bottom + 10); ;
                Controls.Add(newLabel1);
                newTextBox = new System.Windows.Forms.TextBox();
                newTextBox.Size = new Size(400, 39);
                newTextBox.Location = new Point(newLabel1.Location.X, newLabel1.Bounds.Bottom);
                Controls.Add(newTextBox);
                newLabelCount = new Label();
                newLabelCount.Size = new Size(400, newLabelCount.Size.Height);
                newLabelCount.Text = "Enter the number of variants of answers";
                newLabelCount.Location = new Point(newTextBox.Location.X, newTextBox.Bounds.Bottom + 10);
                Controls.Add(newLabelCount);
                newTextBoxCount = new System.Windows.Forms.TextBox();
                newTextBoxCount.Size = new Size(70, 39);
                newTextBoxCount.Location = new Point(newLabel1.Location.X, newLabelCount.Bounds.Bottom);
                Controls.Add(newTextBoxCount);
                newButton1 = new System.Windows.Forms.Button();
                newButton1.Text = "Go";
                newButton1.Location = new Point(newTextBoxCount.Bounds.Right + 15, newTextBoxCount.Location.Y);
                Controls.Add(newButton1);
                newButton1.Click += new EventHandler(newButton1_Click);
                questionCount++;
            }
            else if (selectedOption == "Some variants question")
            {
                Controls.Remove(newButtonFinish);
                Controls.Remove(comboBoxAddTestPage1);
                Label newLabel1 = new Label();
                newLabel1.Text = "Question " + questionCount.ToString();
                newLabel1.Location = new Point(labelTestAddTestPage.Location.X, labelTestAddTestPage.Bounds.Bottom + 10); ;
                Controls.Add(newLabel1);
                newTextBox = new System.Windows.Forms.TextBox();
                newTextBox.Size = new Size(400, 39);
                newTextBox.Location = new Point(newLabel1.Location.X, newLabel1.Bounds.Bottom);
                Controls.Add(newTextBox);
                newLabelCount = new Label();
                newLabelCount.Size = new Size(400, newLabelCount.Size.Height);
                newLabelCount.Text = "Enter the number of variants of answers";
                newLabelCount.Location = new Point(newTextBox.Location.X, newTextBox.Bounds.Bottom + 10);
                Controls.Add(newLabelCount);
                newTextBoxCount = new System.Windows.Forms.TextBox();
                newTextBoxCount.Size = new Size(70, 39);
                newTextBoxCount.Location = new Point(newLabel1.Location.X, newLabelCount.Bounds.Bottom);
                Controls.Add(newTextBoxCount);
                newButton4 = new System.Windows.Forms.Button();
                newButton4.Text = "Go";
                newButton4.Location = new Point(newTextBoxCount.Bounds.Right + 15, newTextBoxCount.Location.Y);
                Controls.Add(newButton4);
                newButton4.Click += new EventHandler(newButton4_Click);
                questionCount++;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            DetailedAnswer questionDet = new DetailedAnswer();
            questionDet.QuestionText = newTextBox.Text;
            questionDet.TextAnswer = newTextBox1.Text;
            test.QuestionsArr.Add(questionDet);
            Controls.Clear();
            Label newLabelTest = new Label();
            newLabelTest.Font = new Font(newLabelTest.Font.FontFamily, 15);
            newLabelTest.Text = "Test";
            newLabelTest.Location = new Point(17, 13);
            Controls.Add(newLabelTest);
            comboBoxAddTestPage1.Location = new Point(newLabelTest.Location.X + 5, newLabelTest.Bounds.Bottom + 15);
            Controls.Add(comboBoxAddTestPage1);
            newButtonFinish = new System.Windows.Forms.Button();
            newButtonFinish.Location = new Point(comboBoxAddTestPage1.Bounds.Right + 15, comboBoxAddTestPage1.Location.Y);
            newButtonFinish.Text = "Finish";
            Controls.Add(newButtonFinish);
            newButtonFinish.Click += new EventHandler(newButtonFinish_Click);
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            CountOfVariants = Convert.ToInt32(newTextBoxCount.Text);
            Controls.Remove(newTextBoxCount);
            Controls.Remove(newButton1);
            newLabelCount.Text = "Enter variants of answers";
            newTextBox2 = new System.Windows.Forms.TextBox();
            newTextBox2.Size = new Size(400, 39);
            newTextBox2.Location = new Point(newLabelCount.Location.X, newLabelCount.Bounds.Bottom);
            Controls.Add(newTextBox2);
            newButton2 = new System.Windows.Forms.Button();
            newButton2.Location = new Point(newTextBox2.Bounds.Right + 15, newTextBox2.Location.Y);
            newButton2.Text = "OK";
            Controls.Add(newButton2);
            newButton2.Click += new EventHandler(newButton2_Click);
        }
        private void newButton2_Click(object sender, EventArgs e)
        {
            questionOV = new OneRightVariantQuestion();
            questionOV.VariantAnswerArr.Add(newTextBox2.Text);
            if (counter < CountOfVariants)
            {
                Controls.Remove(newButton2);
                newTextBox2 = new System.Windows.Forms.TextBox();
                newTextBox2.Size = new Size(400, 39);
                newTextBox2.Location = new Point(newLabelCount.Location.X, newLabelCount.Bounds.Bottom + 39 * counter);
                Controls.Add(newTextBox2);
                newButton2 = new System.Windows.Forms.Button();
                newButton2.Location = new Point(newTextBox2.Bounds.Right + 15, newTextBox2.Location.Y);
                newButton2.Text = "OK";
                Controls.Add(newButton2);
                newButton2.Click += new EventHandler(newButton2_Click);
                counter++;
            }
            else
            {
                Controls.Remove(newButton2);
                newLabelCount = new Label();
                newLabelCount.Location = new Point(newTextBox2.Location.X, newTextBox2.Bounds.Bottom + 10);
                newLabelCount.Text = "Enter the number of the right variant";
                newLabelCount.Size = new Size(400, newLabelCount.Size.Height);
                Controls.Add(newLabelCount);
                newTextBox2 = new System.Windows.Forms.TextBox();
                newTextBox2.Size = new Size(70, 39);
                newTextBox2.Location = new Point(newLabelCount.Location.X, newLabelCount.Bounds.Bottom);
                Controls.Add(newTextBox2);
                System.Windows.Forms.Button newButton3 = new System.Windows.Forms.Button();
                newButton3.Location = new Point(newTextBox2.Bounds.Right + 15, newTextBox2.Location.Y);
                newButton3.Text = "Go";
                Controls.Add(newButton3);
                newButton3.Click += new EventHandler(newButton3_Click);
                counter = 1;
            }
        }

        private void newButton3_Click(object sender, EventArgs e)
        {
            questionOV.QuestionText = newTextBox.Text;
            questionOV.RightVariantAnswer = Convert.ToInt32(newTextBox2.Text) - 1;
            test.QuestionsArr.Add(questionOV);
            Controls.Clear();
            Label newLabelTest = new Label();
            newLabelTest.Font = new Font(newLabelTest.Font.FontFamily, 15);
            newLabelTest.Text = "Test";
            newLabelTest.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            newLabelTest.Location = new Point(17, 13);
            Controls.Add(newLabelTest);
            comboBoxAddTestPage1.Location = new Point(newLabelTest.Location.X + 5, newLabelTest.Bounds.Bottom + 15);
            Controls.Add(comboBoxAddTestPage1);
            newButtonFinish = new System.Windows.Forms.Button();
            newButtonFinish.Location = new Point(comboBoxAddTestPage1.Bounds.Right + 15, comboBoxAddTestPage1.Location.Y);
            newButtonFinish.Text = "Finish";
            Controls.Add(newButtonFinish);
            newButtonFinish.Click += new EventHandler(newButtonFinish_Click);
        }

        private void newButton4_Click(object sender, EventArgs e)
        {
            CountOfVariants = Convert.ToInt32(newTextBoxCount.Text);
            Controls.Remove(newTextBoxCount);
            Controls.Remove(newButton4);
            newLabelCount.Text = "Enter variants of answers";
            newTextBox2 = new System.Windows.Forms.TextBox();
            newTextBox2.Size = new Size(400, 39);
            newTextBox2.Location = new Point(newLabelCount.Location.X, newLabelCount.Bounds.Bottom);
            Controls.Add(newTextBox2);
            newButton5 = new System.Windows.Forms.Button();
            newButton5.Location = new Point(newTextBox2.Bounds.Right + 15, newTextBox2.Location.Y);
            newButton5.Text = "OK";
            Controls.Add(newButton5);
            newButton5.Click += new EventHandler(newButton5_Click);
        }

        private void newButton5_Click(object sender, EventArgs e)
        {
            questionSV = new SomeRightVariantsQuestion();
            questionSV.VariantAnswerArr.Add(newTextBox2.Text);
            if (counter < CountOfVariants)
            {
                Controls.Remove(newButton5);
                newTextBox2 = new System.Windows.Forms.TextBox();
                newTextBox2.Size = new Size(400, 39);
                newTextBox2.Location = new Point(newLabelCount.Location.X, newLabelCount.Bounds.Bottom + 39 * counter);
                Controls.Add(newTextBox2);
                newButton5 = new System.Windows.Forms.Button();
                newButton5.Location = new Point(newTextBox2.Bounds.Right + 15, newTextBox2.Location.Y);
                newButton5.Text = "OK";
                Controls.Add(newButton5);
                newButton5.Click += new EventHandler(newButton5_Click);
                counter++;
            }
            else
            {
                Controls.Remove(newButton5);
                newLabelCount = new Label();
                newLabelCount.Location = new Point(newTextBox2.Location.X, newTextBox2.Bounds.Bottom + 10);
                newLabelCount.Text = "Enter the number of the right variant";
                newLabelCount.Size = new Size(400, newLabelCount.Size.Height);
                Controls.Add(newLabelCount);
                newTextBox4 = new System.Windows.Forms.TextBox();
                newTextBox4.Size = new Size(70, 39);
                newTextBox4.Location = new Point(newLabelCount.Location.X, newLabelCount.Bounds.Bottom);
                Controls.Add(newTextBox4);
                newButton6 = new System.Windows.Forms.Button();
                newButton6.Location = new Point(newTextBox4.Bounds.Right + 15, newTextBox4.Location.Y);
                newButton6.Text = "Go";
                Controls.Add(newButton6);
                newButton6.Click += new EventHandler(newButton6_Click);
                counter = 1;
            }
        }

        private void newButton6_Click(object sender, EventArgs e)
        {
            CountOfVariants = Convert.ToInt32(newTextBox4.Text);
            Controls.Remove(newLabelCount);
            Controls.Remove(newTextBox4);
            Controls.Remove(newButton6);
            newLabelCount1 = new Label();
            newLabelCount1.Size = new Size(400, newLabelCount1.Size.Height);
            newLabelCount1.Text = "Enter the numbers of right variants of answers";
            newLabelCount1.Location = new Point(newTextBox2.Location.X, newTextBox2.Bounds.Bottom + 10);
            Controls.Add(newLabelCount1);
            newTextBoxCount1 = new System.Windows.Forms.TextBox();
            newTextBoxCount1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            newTextBoxCount1.Size = new Size(400, 39);
            newTextBoxCount1.Location = new Point(newLabelCount1.Location.X, newLabelCount1.Bounds.Bottom);
            Controls.Add(newTextBoxCount1);
            newButton8 = new System.Windows.Forms.Button();
            newButton8.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            newButton8.Text = "OK";
            newButton8.Location = new Point(newTextBoxCount1.Bounds.Right + 15, newTextBoxCount1.Location.Y);
            Controls.Add(newButton8);
            newButton8.Click += new EventHandler(newButton8_Click);
        }
        private void newButton8_Click(object sender, EventArgs e)
        {
            questionSV.RightVariantsAnswer.Add(Convert.ToInt32(newTextBoxCount1.Text) - 1);
            if (counter < CountOfVariants)
            {
                Controls.Remove(newButton8);
                newTextBox3 = new System.Windows.Forms.TextBox();
                newTextBox3.Size = new Size(400, 39);
                newTextBox3.Location = new Point(newLabelCount1.Location.X, newLabelCount1.Bounds.Bottom + 39 * counter);
                Controls.Add(newTextBox3);
                newButton8 = new System.Windows.Forms.Button();
                newButton8.Location = new Point(newTextBox3.Bounds.Right + 15, newTextBox3.Location.Y);
                newButton8.Text = "OK";
                Controls.Add(newButton8);
                newButton8.Click += new EventHandler(newButton8_Click);
                counter++;
            }
            else
            {
                Controls.Remove(newButton8);
                counter = 1;
                questionSV.QuestionText = newTextBox.Text;
                test.QuestionsArr.Add(questionSV);
                Controls.Clear();
                Label newLabelTest = new Label();
                newLabelTest.Font = new Font(newLabelTest.Font.FontFamily, 15);
                newLabelTest.Text = "Test";
                newLabelTest.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                newLabelTest.Location = new Point(17, 13);
                Controls.Add(newLabelTest);
                comboBoxAddTestPage1.Location = new Point(newLabelTest.Location.X + 5, newLabelTest.Bounds.Bottom + 15);
                Controls.Add(comboBoxAddTestPage1);
                newButtonFinish = new System.Windows.Forms.Button();
                newButtonFinish.Location = new Point(comboBoxAddTestPage1.Bounds.Right + 15, comboBoxAddTestPage1.Location.Y);
                newButtonFinish.Text = "Finish";
                Controls.Add(newButtonFinish);
                newButtonFinish.Click += new EventHandler(newButtonFinish_Click);
            }
        }

        private void newButtonFinish_Click(object sender, EventArgs e)
        {

            editor.TestArr.Add(test);
            this.Hide();
            CourseWorkTeacherEditor courseWorkTeacherEditor = new CourseWorkTeacherEditor(editor);
            courseWorkTeacherEditor.Show();
        }
    }
}

