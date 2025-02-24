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
            lbPassword = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(105, 63);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(83, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "lbPassword";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(194, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(344, 27);
            txtPassword.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
