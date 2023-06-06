namespace CourseWorkWinForms
{
    partial class CourseWorkTeacherEditor
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
            buttonAddTestOnTEditorPage = new Button();
            labelAuthTeacherOnTEditor = new Label();
            buttonLogOutOnTEditorPage = new Button();
            SuspendLayout();
            // 
            // buttonAddTestOnTEditorPage
            // 
            buttonAddTestOnTEditorPage.Location = new Point(194, 233);
            buttonAddTestOnTEditorPage.Name = "buttonAddTestOnTEditorPage";
            buttonAddTestOnTEditorPage.Size = new Size(150, 60);
            buttonAddTestOnTEditorPage.TabIndex = 0;
            buttonAddTestOnTEditorPage.Text = "Add Test";
            buttonAddTestOnTEditorPage.UseVisualStyleBackColor = true;
            buttonAddTestOnTEditorPage.Click += buttonAddTestOnTEditorPage_Click;
            // 
            // labelAuthTeacherOnTEditor
            // 
            labelAuthTeacherOnTEditor.AutoSize = true;
            labelAuthTeacherOnTEditor.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthTeacherOnTEditor.Location = new Point(62, 40);
            labelAuthTeacherOnTEditor.MaximumSize = new Size(400, 0);
            labelAuthTeacherOnTEditor.Name = "labelAuthTeacherOnTEditor";
            labelAuthTeacherOnTEditor.Size = new Size(394, 108);
            labelAuthTeacherOnTEditor.TabIndex = 1;
            labelAuthTeacherOnTEditor.Text = "Congratulations! You logged in as teacher!";
            // 
            // buttonLogOutOnTEditorPage
            // 
            buttonLogOutOnTEditorPage.Location = new Point(194, 373);
            buttonLogOutOnTEditorPage.Name = "buttonLogOutOnTEditorPage";
            buttonLogOutOnTEditorPage.Size = new Size(150, 60);
            buttonLogOutOnTEditorPage.TabIndex = 5;
            buttonLogOutOnTEditorPage.Text = "Log Out";
            buttonLogOutOnTEditorPage.UseVisualStyleBackColor = true;
            buttonLogOutOnTEditorPage.Click += buttonLogOutOnTEditorPage_Click;
            // 
            // CourseWorkTeacherEditor
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 629);
            Controls.Add(buttonLogOutOnTEditorPage);
            Controls.Add(labelAuthTeacherOnTEditor);
            Controls.Add(buttonAddTestOnTEditorPage);
            Name = "CourseWorkTeacherEditor";
            Text = "CourseWorkTeacherEditor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddTestOnTEditorPage;
        private Label labelAuthTeacherOnTEditor;
        private Button buttonLogOutOnTEditorPage;
    }
}