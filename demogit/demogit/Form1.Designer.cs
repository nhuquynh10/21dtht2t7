namespace demogit
{
    partial class Form1
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
            lbUserName = new Label();
            txtUserName = new TextBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(105, 97);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(78, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(194, 97);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(422, 27);
            txtUserName.TabIndex = 1;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(93, 149);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(193, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(423, 27);
            txtPassword.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(194, 214);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPassword;
        private TextBox txtPassword;

        private Label lbUserName;
        private TextBox txtUserName;
        private Button button1;
    }
}
