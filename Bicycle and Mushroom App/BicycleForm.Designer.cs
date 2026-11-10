namespace Bicycle_and_Mushroom_App
{
    partial class BicycleForm
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
            lblStartHour = new Label();
            lblEndHour = new Label();
            txtEndHour = new MaskedTextBox();
            txtStartHour = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            lblResultTitle = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(338, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BICYCLE RENTAL";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblStartHour
            // 
            lblStartHour.AutoSize = true;
            lblStartHour.Location = new Point(107, 125);
            lblStartHour.Name = "lblStartHour";
            lblStartHour.Size = new Size(123, 25);
            lblStartHour.TabIndex = 1;
            lblStartHour.Text = "Starting Hour ";
            // 
            // lblEndHour
            // 
            lblEndHour.AutoSize = true;
            lblEndHour.Location = new Point(107, 227);
            lblEndHour.Name = "lblEndHour";
            lblEndHour.Size = new Size(114, 25);
            lblEndHour.TabIndex = 2;
            lblEndHour.Text = "Ending hour ";
            // 
            // txtEndHour
            // 
            txtEndHour.Location = new Point(312, 227);
            txtEndHour.Name = "txtEndHour";
            txtEndHour.Size = new Size(150, 31);
            txtEndHour.TabIndex = 3;
            // 
            // txtStartHour
            // 
            txtStartHour.Location = new Point(312, 125);
            txtStartHour.Name = "txtStartHour";
            txtStartHour.Size = new Size(150, 31);
            txtStartHour.TabIndex = 4;
            txtStartHour.TextChanged += txtStartHour_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(187, 288);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(275, 34);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(615, 404);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 6;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // lblResultTitle
            // 
            lblResultTitle.AutoSize = true;
            lblResultTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultTitle.Location = new Point(107, 345);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(150, 28);
            lblResultTitle.TabIndex = 7;
            lblResultTitle.Text = "Bicycle Result ";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(327, 345);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(309, 28);
            lblResult.TabIndex = 8;
            lblResult.Text = "Bicycle Result will appear here ";
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(lblResultTitle);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtStartHour);
            Controls.Add(txtEndHour);
            Controls.Add(lblEndHour);
            Controls.Add(lblStartHour);
            Controls.Add(lblTitle);
            Name = "BicycleForm";
            Text = "BicycleForm";
            Load += BicycleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStartHour;
        private Label lblEndHour;
        private MaskedTextBox txtEndHour;
        private TextBox txtStartHour;
        private Button btnCalculate;
        private Button btnExit;
        private Label lblResultTitle;
        private Label lblResult;
    }
}