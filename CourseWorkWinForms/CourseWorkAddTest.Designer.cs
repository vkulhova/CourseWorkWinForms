namespace CourseWorkWinForms
{
    partial class CourseWorkAddTest
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
            labelTestAddTestPage = new Label();
            comboBoxAddTestPage1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // labelTestAddTestPage
            // 
            labelTestAddTestPage.AutoSize = true;
            labelTestAddTestPage.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTestAddTestPage.Location = new Point(31, 26);
            labelTestAddTestPage.Margin = new Padding(0);
            labelTestAddTestPage.Name = "labelTestAddTestPage";
            labelTestAddTestPage.Size = new Size(92, 54);
            labelTestAddTestPage.TabIndex = 0;
            labelTestAddTestPage.Text = "Test";
            // 
            // comboBoxAddTestPage1
            // 
            comboBoxAddTestPage1.FormattingEnabled = true;
            comboBoxAddTestPage1.Location = new Point(43, 96);
            comboBoxAddTestPage1.Margin = new Padding(0);
            comboBoxAddTestPage1.Name = "comboBoxAddTestPage1";
            comboBoxAddTestPage1.Size = new Size(242, 40);
            comboBoxAddTestPage1.TabIndex = 2;
            comboBoxAddTestPage1.SelectedIndexChanged += comboBoxAddTestPage1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 406);
            label2.Name = "label2";
            label2.Size = new Size(0, 32);
            label2.TabIndex = 3;
            // 
            // CourseWorkAddTest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 1006);
            Controls.Add(label2);
            Controls.Add(comboBoxAddTestPage1);
            Controls.Add(labelTestAddTestPage);
            Name = "CourseWorkAddTest";
            Text = "CourseWorkAddTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTestAddTestPage;
        private ComboBox comboBoxAddTestPage1;
        private Label label2;
    }
}