namespace CourseWorkWinForms
{
    partial class CourseWorkLogin
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
            logInButtonOnAuthPage = new Button();
            labelTestsOnAuthPage = new Label();
            signInButtonOnAuthPage = new Button();
            SuspendLayout();
            // 
            // logInButtonOnAuthPage
            // 
            logInButtonOnAuthPage.Location = new Point(194, 263);
            logInButtonOnAuthPage.Name = "logInButtonOnAuthPage";
            logInButtonOnAuthPage.Size = new Size(150, 60);
            logInButtonOnAuthPage.TabIndex = 0;
            logInButtonOnAuthPage.Text = "Log in";
            logInButtonOnAuthPage.UseVisualStyleBackColor = true;
            logInButtonOnAuthPage.Click += logInButtonOnAuthPage_Click;
            // 
            // labelTestsOnAuthPage
            // 
            labelTestsOnAuthPage.AutoSize = true;
            labelTestsOnAuthPage.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            labelTestsOnAuthPage.Location = new Point(145, 78);
            labelTestsOnAuthPage.Name = "labelTestsOnAuthPage";
            labelTestsOnAuthPage.Size = new Size(254, 125);
            labelTestsOnAuthPage.TabIndex = 1;
            labelTestsOnAuthPage.Text = "Tests";
            // 
            // signInButtonOnAuthPage
            // 
            signInButtonOnAuthPage.Location = new Point(194, 377);
            signInButtonOnAuthPage.Name = "signInButtonOnAuthPage";
            signInButtonOnAuthPage.Size = new Size(150, 60);
            signInButtonOnAuthPage.TabIndex = 2;
            signInButtonOnAuthPage.Text = "Sign in";
            signInButtonOnAuthPage.UseVisualStyleBackColor = true;
            signInButtonOnAuthPage.Click += signInButtonOnAuthPage_Click;
            // 
            // CourseWorkLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 629);
            Controls.Add(signInButtonOnAuthPage);
            Controls.Add(labelTestsOnAuthPage);
            Controls.Add(logInButtonOnAuthPage);
            Name = "CourseWorkLogin";
            Text = "CourseWorkLogin";
            Load += CourseWorkLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logInButtonOnAuthPage;
        private Label labelTestsOnAuthPage;
        private Button signInButtonOnAuthPage;
    }
}