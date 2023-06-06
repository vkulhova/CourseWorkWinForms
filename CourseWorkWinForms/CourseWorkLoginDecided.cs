using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CourseWorkLoginDecided : Form
    {
        private Editor editor;
        public CourseWorkLoginDecided(Editor editor)
        {
            InitializeComponent();
            this.editor = editor;
        }

        private void labelBackOnLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkLogin courseWorkLogin = new CourseWorkLogin();
            courseWorkLogin.Show();
        }

        private void labelSignInOnLoginPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkSigninDecided courseWorkSigninDecided = new CourseWorkSigninDecided(editor);
            courseWorkSigninDecided.Show();
        }

        private void buttonLogInOnLoginPage_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();

            User user = auth.UserArr.Find(user => fieldUNOnLoginPage.Text == user.username && fieldPassOnLoginPage.Text == user.password);
            if (user != null)
            {
                if (radioButtonTeacherOnLoginPage.Checked)
                {
                    this.Hide();
                    CourseWorkTeacherEditor courseWorkTeacherEditor = new CourseWorkTeacherEditor(editor);
                    courseWorkTeacherEditor.Show();
                }
                else if (radioButtonStudentOnLoginPage.Checked)
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
            else
            {
                if (radioButtonTeacherOnLoginPage.Checked)
                {
                    MessageBox.Show("You entered incorrect user name or password.\nTry again.");
                }
                if (radioButtonStudentOnLoginPage.Checked)
                {
                    MessageBox.Show("You entered incorrect user name or password.\nTry again.");
                }
            }
        }
    }
}
