using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWinForms
{
    public partial class CourseWorkSigninDecided : Form
    {
        private Editor editor;
        public CourseWorkSigninDecided(Editor editor)
        {
            InitializeComponent();
            this.editor = editor;
        }

        private void labelBackOnSigninPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkLogin courseWorkLogin = new CourseWorkLogin();
            courseWorkLogin.Show();
        }

        private void labelLogInOnSigninPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkLoginDecided courseWorkLoginDecided = new CourseWorkLoginDecided(editor);
            courseWorkLoginDecided.Show();
        }

        private void buttonSignInOnSigninPage_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();

            User user = auth.UserArr.Find(user => fieldUNOnSigninPage.Text == user.username);
            if (user != null)
            {
                MessageBox.Show("This user name is already used.");
            }
            else
            {
                auth.UserArr.Add(new User(fieldUNOnSigninPage.Text, fieldPassOnSigninPage.Text));
                if (radioButtonTeacherOnSigninPage.Checked)
                {
                    this.Hide();
                    CourseWorkTeacherEditor courseWorkTeacherEditor = new CourseWorkTeacherEditor(editor);
                    courseWorkTeacherEditor.Show();
                }
                else if (radioButtonStudentOnSigninPage.Checked)
                {
                    this.Hide();
                    CourseWorkStudentEditor courseWorkStudentEditor = new CourseWorkStudentEditor(editor);
                    courseWorkStudentEditor.Show();
                }
                else
                {
                    MessageBox.Show("You did not decide the role.\nPlease choose teacher or student.");
                }
            }
        }
    }
}
