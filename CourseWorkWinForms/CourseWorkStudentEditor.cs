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
    public partial class CourseWorkStudentEditor : Form
    {
        private Editor editor;
        public CourseWorkStudentEditor(Editor editor)
        {
            this.editor = editor;
            InitializeComponent();
        }

        private void buttonLogOutOnSEditorPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkLogin courseWorkLogin = new CourseWorkLogin();
            courseWorkLogin.Show();
        }

        private void buttonChooseTestOnSEditorPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkStartTest courseWorkStartTest = new CourseWorkStartTest(editor);
            courseWorkStartTest.Show();
        }
    }
}
