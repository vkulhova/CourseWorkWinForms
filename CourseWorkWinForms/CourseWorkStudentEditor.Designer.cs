namespace CourseWorkWinForms
{
    partial class CourseWorkStudentEditor
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
            labelAuthStudSEditorPage = new Label();
            buttonChooseTestOnSEditorPage = new Button();
            buttonLogOutOnSEditorPage = new Button();
            SuspendLayout();
            // 
            // labelAuthStudSEditorPage
            // 
            labelAuthStudSEditorPage.AutoSize = true;
            labelAuthStudSEditorPage.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthStudSEditorPage.Location = new Point(62, 40);
            labelAuthStudSEditorPage.MaximumSize = new Size(400, 0);
            labelAuthStudSEditorPage.Name = "labelAuthStudSEditorPage";
            labelAuthStudSEditorPage.Size = new Size(399, 108);
            labelAuthStudSEditorPage.TabIndex = 0;
            labelAuthStudSEditorPage.Text = "Congratulations! You logged in as student!";
            // 
            // buttonChooseTestOnSEditorPage
            // 
            buttonChooseTestOnSEditorPage.Location = new Point(184, 233);
            buttonChooseTestOnSEditorPage.Name = "buttonChooseTestOnSEditorPage";
            buttonChooseTestOnSEditorPage.Size = new Size(160, 60);
            buttonChooseTestOnSEditorPage.TabIndex = 1;
            buttonChooseTestOnSEditorPage.Text = "Choose Test";
            buttonChooseTestOnSEditorPage.UseVisualStyleBackColor = true;
            buttonChooseTestOnSEditorPage.Click += buttonChooseTestOnSEditorPage_Click;
            // 
            // buttonLogOutOnSEditorPage
            // 
            buttonLogOutOnSEditorPage.Location = new Point(184, 373);
            buttonLogOutOnSEditorPage.Name = "buttonLogOutOnSEditorPage";
            buttonLogOutOnSEditorPage.Size = new Size(160, 60);
            buttonLogOutOnSEditorPage.TabIndex = 2;
            buttonLogOutOnSEditorPage.Text = "Log Out";
            buttonLogOutOnSEditorPage.UseVisualStyleBackColor = true;
            buttonLogOutOnSEditorPage.Click += buttonLogOutOnSEditorPage_Click;
            // 
            // CourseWorkStudentEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 629);
            Controls.Add(buttonLogOutOnSEditorPage);
            Controls.Add(buttonChooseTestOnSEditorPage);
            Controls.Add(labelAuthStudSEditorPage);
            Name = "CourseWorkStudentEditor";
            Text = "CourseWorkStudentEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAuthStudSEditorPage;
        private Button buttonChooseTestOnSEditorPage;
        private Button buttonLogOutOnSEditorPage;
    }
}