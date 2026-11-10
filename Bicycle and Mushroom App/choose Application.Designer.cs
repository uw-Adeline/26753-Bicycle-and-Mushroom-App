namespace Bicycle_and_Mushroom_App
{
    partial class choose_Application
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
            btnRental = new Button();
            btnmushroom = new Button();
            SuspendLayout();
            // 
            // btnRental
            // 
            btnRental.BackColor = SystemColors.MenuHighlight;
            btnRental.Location = new Point(60, 119);
            btnRental.Name = "btnRental";
            btnRental.Size = new Size(194, 78);
            btnRental.TabIndex = 0;
            btnRental.Text = "bicycle form";
            btnRental.UseVisualStyleBackColor = false;
            btnRental.Click += btnRental_Click;
            // 
            // btnmushroom
            // 
            btnmushroom.BackColor = SystemColors.MenuHighlight;
            btnmushroom.Location = new Point(405, 119);
            btnmushroom.Name = "btnmushroom";
            btnmushroom.Size = new Size(192, 78);
            btnmushroom.TabIndex = 1;
            btnmushroom.Text = "Mushroom form";
            btnmushroom.UseVisualStyleBackColor = false;
            btnmushroom.Click += btnmushroom_Click;
            // 
            // choose_Application
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(675, 312);
            Controls.Add(btnmushroom);
            Controls.Add(btnRental);
            Name = "choose_Application";
            Text = "choose form ";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRental;
        private Button btnmushroom;
    }
}