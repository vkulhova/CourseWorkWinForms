namespace CourseWorkWinForms
{
    partial class CourseWorkLoginDecided
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
            labelLoginOnLoginPage = new Label();
            fieldUNOnLoginPage = new TextBox();
            fieldPassOnLoginPage = new TextBox();
            labelEnterUNOnLoginPage = new Label();
            labelEnterPassOnLoginPage = new Label();
            buttonLogInOnLoginPage = new Button();
            panel1 = new Panel();
            radioButtonStudentOnLoginPage = new RadioButton();
            radioButtonTeacherOnLoginPage = new RadioButton();
            labelBackOnLoginPage = new Label();
            labelSignInOnLoginPage = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelLoginOnLoginPage
            // 
            labelLoginOnLoginPage.AutoSize = true;
            labelLoginOnLoginPage.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            labelLoginOnLoginPage.Location = new Point(115, 52);
            labelLoginOnLoginPage.Name = "labelLoginOnLoginPage";
            labelLoginOnLoginPage.Size = new Size(309, 125);
            labelLoginOnLoginPage.TabIndex = 0;
            labelLoginOnLoginPage.Text = "Log in";
            // 
            // fieldUNOnLoginPage
            // 
            fieldUNOnLoginPage.Location = new Point(115, 255);
            fieldUNOnLoginPage.Name = "fieldUNOnLoginPage";
            fieldUNOnLoginPage.Size = new Size(300, 39);
            fieldUNOnLoginPage.TabIndex = 1;
            // 
            // fieldPassOnLoginPage
            // 
            fieldPassOnLoginPage.Location = new Point(115, 363);
            fieldPassOnLoginPage.Name = "fieldPassOnLoginPage";
            fieldPassOnLoginPage.Size = new Size(300, 39);
            fieldPassOnLoginPage.TabIndex = 2;
            fieldPassOnLoginPage.UseSystemPasswordChar = true;
            // 
            // labelEnterUNOnLoginPage
            // 
            labelEnterUNOnLoginPage.AutoSize = true;
            labelEnterUNOnLoginPage.Location = new Point(111, 218);
            labelEnterUNOnLoginPage.Name = "labelEnterUNOnLoginPage";
            labelEnterUNOnLoginPage.Size = new Size(243, 32);
            labelEnterUNOnLoginPage.TabIndex = 3;
            labelEnterUNOnLoginPage.Text = "Enter your user name";
            // 
            // labelEnterPassOnLoginPage
            // 
            labelEnterPassOnLoginPage.AutoSize = true;
            labelEnterPassOnLoginPage.Location = new Point(111, 325);
            labelEnterPassOnLoginPage.Name = "labelEnterPassOnLoginPage";
            labelEnterPassOnLoginPage.Size = new Size(230, 32);
            labelEnterPassOnLoginPage.TabIndex = 4;
            labelEnterPassOnLoginPage.Text = "Enter your password";
            // 
            // buttonLogInOnLoginPage
            // 
            buttonLogInOnLoginPage.Location = new Point(190, 481);
            buttonLogInOnLoginPage.Name = "buttonLogInOnLoginPage";
            buttonLogInOnLoginPage.Size = new Size(150, 60);
            buttonLogInOnLoginPage.TabIndex = 5;
            buttonLogInOnLoginPage.Text = "Log in";
            buttonLogInOnLoginPage.UseVisualStyleBackColor = true;
            buttonLogInOnLoginPage.Click += buttonLogInOnLoginPage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonStudentOnLoginPage);
            panel1.Controls.Add(radioButtonTeacherOnLoginPage);
            panel1.Location = new Point(92, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 51);
            panel1.TabIndex = 6;
            // 
            // radioButtonStudentOnLoginPage
            // 
            radioButtonStudentOnLoginPage.AutoSize = true;
            radioButtonStudentOnLoginPage.Location = new Point(197, 8);
            radioButtonStudentOnLoginPage.Name = "radioButtonStudentOnLoginPage";
            radioButtonStudentOnLoginPage.Size = new Size(128, 36);
            radioButtonStudentOnLoginPage.TabIndex = 1;
            radioButtonStudentOnLoginPage.TabStop = true;
            radioButtonStudentOnLoginPage.Text = "Student";
            radioButtonStudentOnLoginPage.UseVisualStyleBackColor = true;
            // 
            // radioButtonTeacherOnLoginPage
            // 
            radioButtonTeacherOnLoginPage.AutoSize = true;
            radioButtonTeacherOnLoginPage.Location = new Point(29, 8);
            radioButtonTeacherOnLoginPage.Name = "radioButtonTeacherOnLoginPage";
            radioButtonTeacherOnLoginPage.Size = new Size(127, 36);
            radioButtonTeacherOnLoginPage.TabIndex = 0;
            radioButtonTeacherOnLoginPage.TabStop = true;
            radioButtonTeacherOnLoginPage.Text = "Teacher";
            radioButtonTeacherOnLoginPage.UseVisualStyleBackColor = true;
            // 
            // labelBackOnLoginPage
            // 
            labelBackOnLoginPage.AutoSize = true;
            labelBackOnLoginPage.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            labelBackOnLoginPage.Location = new Point(182, 545);
            labelBackOnLoginPage.Name = "labelBackOnLoginPage";
            labelBackOnLoginPage.Size = new Size(167, 32);
            labelBackOnLoginPage.TabIndex = 7;
            labelBackOnLoginPage.Text = "Back To Home";
            labelBackOnLoginPage.Click += labelBackOnLoginPage_Click;
            // 
            // labelSignInOnLoginPage
            // 
            labelSignInOnLoginPage.AutoSize = true;
            labelSignInOnLoginPage.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            labelSignInOnLoginPage.Location = new Point(224, 587);
            labelSignInOnLoginPage.Name = "labelSignInOnLoginPage";
            labelSignInOnLoginPage.Size = new Size(88, 32);
            labelSignInOnLoginPage.TabIndex = 8;
            labelSignInOnLoginPage.Text = "Sign In";
            labelSignInOnLoginPage.Click += labelSignInOnLoginPage_Click;
            // 
            // CourseWorkLoginDecided
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 629);
            Controls.Add(labelSignInOnLoginPage);
            Controls.Add(labelBackOnLoginPage);
            Controls.Add(panel1);
            Controls.Add(buttonLogInOnLoginPage);
            Controls.Add(labelEnterPassOnLoginPage);
            Controls.Add(labelEnterUNOnLoginPage);
            Controls.Add(fieldPassOnLoginPage);
            Controls.Add(fieldUNOnLoginPage);
            Controls.Add(labelLoginOnLoginPage);
            Name = "CourseWorkLoginDecided";
            Text = "CourseWorkLoginDecided";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLoginOnLoginPage;
        private TextBox fieldUNOnLoginPage;
        private TextBox fieldPassOnLoginPage;
        private Label labelEnterUNOnLoginPage;
        private Label labelEnterPassOnLoginPage;
        private Button buttonLogInOnLoginPage;
        private Panel panel1;
        private RadioButton radioButtonTeacherOnLoginPage;
        private RadioButton radioButtonStudentOnLoginPage;
        private Label labelBackOnLoginPage;
        private Label labelSignInOnLoginPage;
    }
}