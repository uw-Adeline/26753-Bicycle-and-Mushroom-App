namespace Bicycle_and_Mushroom_App
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblusername = new Label();
            lblpassword = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            btnlogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(81, 66);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(91, 25);
            lblusername.TabIndex = 0;
            lblusername.Text = "Username";
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Location = new Point(81, 205);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(87, 25);
            lblpassword.TabIndex = 1;
            lblpassword.Text = "Password";
            // 
            // txtusername
            // 
            txtusername.Location = new Point(345, 66);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(150, 31);
            txtusername.TabIndex = 2;
            txtusername.TextChanged += txtusername_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(345, 205);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(150, 31);
            txtpassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Cyan;
            btnlogin.Location = new Point(244, 313);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(164, 71);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Cyan;
            btnExit.Location = new Point(559, 313);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(163, 78);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(861, 471);
            Controls.Add(btnExit);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(lblpassword);
            Controls.Add(lblusername);
            Name = "LoginForm";
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblusername;
        private Label lblpassword;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button btnlogin;
        private Button btnExit;
    }
}
