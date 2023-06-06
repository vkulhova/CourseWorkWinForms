namespace CourseWorkWinForms
{
    partial class CourseWorkSigninDecided
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelSignInOnSigninPage = new Label();
            fieldUNOnSigninPage = new TextBox();
            fieldPassOnSigninPage = new TextBox();
            labelCreateUNOnSigninPage = new Label();
            labelCreatePassOnSigninPage = new Label();
            buttonSignInOnSigninPage = new Button();
            panel1 = new Panel();
            radioButtonStudentOnSigninPage = new RadioButton();
            radioButtonTeacherOnSigninPage = new RadioButton();
            labelBackOnSigninPage = new Label();
            labelLogInOnSigninPage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelSignInOnSigninPage
            // 
            labelSignInOnSigninPage.AutoSize = true;
            labelSignInOnSigninPage.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            labelSignInOnSigninPage.Location = new Point(101, 52);
            labelSignInOnSigninPage.Name = "labelSignInOnSigninPage";
            labelSignInOnSigninPage.Size = new Size(338, 125);
            labelSignInOnSigninPage.TabIndex = 0;
            labelSignInOnSigninPage.Text = "Sign In";
            // 
            // fieldUNOnSigninPage
            // 
            fieldUNOnSigninPage.Location = new Point(115, 255);
            fieldUNOnSigninPage.Name = "fieldUNOnSigninPage";
            fieldUNOnSigninPage.Size = new Size(300, 39);
            fieldUNOnSigninPage.TabIndex = 1;
            // 
            // fieldPassOnSigninPage
            // 
            fieldPassOnSigninPage.Location = new Point(115, 365);
            fieldPassOnSigninPage.Name = "fieldPassOnSigninPage";
            fieldPassOnSigninPage.Size = new Size(300, 39);
            fieldPassOnSigninPage.TabIndex = 2;
            fieldPassOnSigninPage.UseSystemPasswordChar = true;
            // 
            // labelCreateUNOnSigninPage
            // 
            labelCreateUNOnSigninPage.AutoSize = true;
            labelCreateUNOnSigninPage.Location = new Point(111, 218);
            labelCreateUNOnSigninPage.Name = "labelCreateUNOnSigninPage";
            labelCreateUNOnSigninPage.Size = new Size(257, 32);
            labelCreateUNOnSigninPage.TabIndex = 3;
            labelCreateUNOnSigninPage.Text = "Create your user name";
            // 
            // labelCreatePassOnSigninPage
            // 
            labelCreatePassOnSigninPage.AutoSize = true;
            labelCreatePassOnSigninPage.Location = new Point(111, 325);
            labelCreatePassOnSigninPage.Name = "labelCreatePassOnSigninPage";
            labelCreatePassOnSigninPage.Size = new Size(244, 32);
            labelCreatePassOnSigninPage.TabIndex = 4;
            labelCreatePassOnSigninPage.Text = "Create your password";
            // 
            // buttonSignInOnSigninPage
            // 
            buttonSignInOnSigninPage.Location = new Point(190, 481);
            buttonSignInOnSigninPage.Name = "buttonSignInOnSigninPage";
            buttonSignInOnSigninPage.Size = new Size(150, 60);
            buttonSignInOnSigninPage.TabIndex = 5;
            buttonSignInOnSigninPage.Text = "Sign In";
            buttonSignInOnSigninPage.UseVisualStyleBackColor = true;
            buttonSignInOnSigninPage.Click += buttonSignInOnSigninPage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonStudentOnSigninPage);
            panel1.Controls.Add(radioButtonTeacherOnSigninPage);
            panel1.Location = new Point(92, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 51);
            panel1.TabIndex = 6;
            // 
            // radioButtonStudentOnSigninPage
            // 
            radioButtonStudentOnSigninPage.AutoSize = true;
            radioButtonStudentOnSigninPage.Location = new Point(197, 8);
            radioButtonStudentOnSigninPage.Name = "radioButtonStudentOnSigninPage";
            radioButtonStudentOnSigninPage.Size = new Size(128, 36);
            radioButtonStudentOnSigninPage.TabIndex = 7;
            radioButtonStudentOnSigninPage.TabStop = true;
            radioButtonStudentOnSigninPage.Text = "Student";
            radioButtonStudentOnSigninPage.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacherOnSigninPage
            // 
            radioButtonTeacherOnSigninPage.AutoSize = true;
            radioButtonTeacherOnSigninPage.Location = new Point(25, 7);
            radioButtonTeacherOnSigninPage.Name = "radioButtonTeacherOnSigninPage";
            radioButtonTeacherOnSigninPage.Size = new Size(127, 36);
            radioButtonTeacherOnSigninPage.TabIndex = 7;
            radioButtonTeacherOnSigninPage.TabStop = true;
            radioButtonTeacherOnSigninPage.Text = "Teacher";
            radioButtonTeacherOnSigninPage.UseVisualStyleBackColor = true;
            // 
            // labelBackOnSigninPage
            // 
            labelBackOnSigninPage.AutoSize = true;
            labelBackOnSigninPage.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            labelBackOnSigninPage.Location = new Point(182, 545);
            labelBackOnSigninPage.Name = "labelBackOnSigninPage";
            labelBackOnSigninPage.Size = new Size(167, 32);
            labelBackOnSigninPage.TabIndex = 7;
            labelBackOnSigninPage.Text = "Back To Home";
            labelBackOnSigninPage.Click += labelBackOnSigninPage_Click;
            // 
            // labelLogInOnSigninPage
            // 
            labelLogInOnSigninPage.AutoSize = true;
            labelLogInOnSigninPage.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            labelLogInOnSigninPage.Location = new Point(224, 587);
            labelLogInOnSigninPage.Name = "labelLogInOnSigninPage";
            labelLogInOnSigninPage.Size = new Size(80, 32);
            labelLogInOnSigninPage.TabIndex = 8;
            labelLogInOnSigninPage.Text = "Log in";
            labelLogInOnSigninPage.Click += labelLogInOnSigninPage_Click;
            // 
            // CourseWorkSigninDecided
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 629);
            Controls.Add(labelLogInOnSigninPage);
            Controls.Add(labelBackOnSigninPage);
            Controls.Add(panel1);
            Controls.Add(buttonSignInOnSigninPage);
            Controls.Add(labelCreatePassOnSigninPage);
            Controls.Add(labelCreateUNOnSigninPage);
            Controls.Add(fieldPassOnSigninPage);
            Controls.Add(fieldUNOnSigninPage);
            Controls.Add(labelSignInOnSigninPage);
            Name = "CourseWorkSigninDecided";
            Text = "CourseWorkSigninDecided";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSignInOnSigninPage;
        private TextBox fieldUNOnSigninPage;
        private TextBox fieldPassOnSigninPage;
        private Label labelCreateUNOnSigninPage;
        private Label labelCreatePassOnSigninPage;
        private Button buttonSignInOnSigninPage;
        private Panel panel1;
        private RadioButton radioButtonStudentOnSigninPage;
        private RadioButton radioButtonTeacherOnSigninPage;
        private Label labelBackOnSigninPage;
        private Label labelLogInOnSigninPage;
    }
}