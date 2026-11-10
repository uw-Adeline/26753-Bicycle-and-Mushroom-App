namespace Bicycle_and_Mushroom_App
{
    partial class MushroomForm
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
            lblTitle = new Label();
            lblQuestionTitle = new Label();
            lblQuestion = new Label();
            lblInstruction = new Label();
            btnYes = new Button();
            btnNo = new Button();
            lblResultTitle = new Label();
            lblResult = new Label();
            btnReset = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(130, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(528, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MUSHROOM IDENTIFICATION";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // lblQuestionTitle
            // 
            lblQuestionTitle.AutoSize = true;
            lblQuestionTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestionTitle.Location = new Point(28, 84);
            lblQuestionTitle.Name = "lblQuestionTitle";
            lblQuestionTitle.Size = new Size(179, 28);
            lblQuestionTitle.TabIndex = 1;
            lblQuestionTitle.Text = "QUESTION 1 OF 3";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Arial Narrow", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(28, 124);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(433, 37);
            lblQuestion.TabIndex = 2;
            lblQuestion.Text = "Does the mushroom have a ring?";
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstruction.Location = new Point(28, 171);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(332, 25);
            lblInstruction.TabIndex = 3;
            lblInstruction.Text = "Select Yes or No to continue.";
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.Location = new Point(130, 242);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(150, 50);
            btnYes.TabIndex = 5;
            btnYes.Text = "YES";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(392, 242);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(150, 50);
            btnNo.TabIndex = 6;
            btnNo.Text = "NO";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // lblResultTitle
            // 
            lblResultTitle.AutoSize = true;
            lblResultTitle.Font = new Font("Segoe UI", 12F);
            lblResultTitle.Location = new Point(28, 309);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(271, 32);
            lblResultTitle.TabIndex = 7;
            lblResultTitle.Text = "IDENTIFICATION RESULT";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(28, 358);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(228, 25);
            lblResult.TabIndex = 8;
            lblResult.Text = "Your result will appear here.";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F);
            btnReset.Location = new Point(1, 478);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 40);
            btnReset.TabIndex = 9;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.Location = new Point(666, 478);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 40);
            btnExit.TabIndex = 10;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(778, 518);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(lblResult);
            Controls.Add(lblResultTitle);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblInstruction);
            Controls.Add(lblQuestion);
            Controls.Add(lblQuestionTitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MushroomForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mushroom Identification";
            Load += MushroomForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblQuestionTitle;
        private Label lblQuestion;
        private Label lblInstruction;
        private Button btnYes;
        private Button btnNo;
        private Label lblResultTitle;
        private Label lblResult;
        private Button btnReset;
        private Button btnExit;
    }
}