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
    public partial class CourseWorkLogin : Form
    {
        Editor editor = new Editor();
        public CourseWorkLogin()
        {
            InitializeComponent();
        }

        private void logInButtonOnAuthPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkLoginDecided courseWorkLoginDecided = new CourseWorkLoginDecided(editor);
            courseWorkLoginDecided.Show();
        }

        private void signInButtonOnAuthPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkSigninDecided courseWorkSigninDecided = new CourseWorkSigninDecided(editor);
            courseWorkSigninDecided.Show();
        }

        private void CourseWorkLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
