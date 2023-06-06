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
    public partial class CourseWorkTeacherEditor : Form
    {
        private Editor editor;
        public CourseWorkTeacherEditor(Editor editor)
        {
            InitializeComponent();
            this.editor = editor;
        }

        private void buttonLogOutOnTEditorPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkLoginDecided courseWorkLoginDecided = new CourseWorkLoginDecided(editor);
            courseWorkLoginDecided.Show();
        }

        private void buttonAddTestOnTEditorPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourseWorkAddTest courseWorkAddTest = new CourseWorkAddTest(editor);
            courseWorkAddTest.Show();
        }
    }
}
