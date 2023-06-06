namespace CourseWorkWinForms
{
    partial class CourseWorkStartTest
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
            labelTestStartTestPage = new Label();
            QuestionNum = new Label();
            QuestionText = new Label();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // labelTestStartTestPage
            // 
            labelTestStartTestPage.AutoSize = true;
            labelTestStartTestPage.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTestStartTestPage.Location = new Point(31, 26);
            labelTestStartTestPage.Margin = new Padding(0);
            labelTestStartTestPage.Name = "labelTestStartTestPage";
            labelTestStartTestPage.Size = new Size(92, 54);
            labelTestStartTestPage.TabIndex = 1;
            labelTestStartTestPage.Text = "Test";
            // 
            // QuestionNum
            // 
            QuestionNum.AutoSize = true;
            QuestionNum.Location = new Point(40, 89);
            QuestionNum.Name = "QuestionNum";
            QuestionNum.Size = new Size(0, 32);
            QuestionNum.TabIndex = 2;
            // 
            // QuestionText
            // 
            QuestionText.AutoSize = true;
            QuestionText.Location = new Point(40, 134);
            QuestionText.Name = "QuestionText";
            QuestionText.Size = new Size(0, 32);
            QuestionText.TabIndex = 3;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(40, 90);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(150, 46);
            buttonStart.TabIndex = 4;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // CourseWorkStartTest
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 669);
            Controls.Add(buttonStart);
            Controls.Add(QuestionText);
            Controls.Add(QuestionNum);
            Controls.Add(labelTestStartTestPage);
            Name = "CourseWorkStartTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTestStartTestPage;
        private Label QuestionNum;
        private Label QuestionText;
        private Button buttonStart;
    }
}