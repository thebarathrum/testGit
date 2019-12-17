namespace test_Klyuev_Alexander
{
    partial class Reg
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
            this.Sign_Up = new System.Windows.Forms.Button();
            this.L_Password = new System.Windows.Forms.Label();
            this.L_Login = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Sign_Up
            // 
            this.Sign_Up.Location = new System.Drawing.Point(604, 484);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(86, 37);
            this.Sign_Up.TabIndex = 9;
            this.Sign_Up.Text = "Sign UP";
            this.Sign_Up.UseVisualStyleBackColor = true;
            this.Sign_Up.Click += new System.EventHandler(this.Sign_Up_Click);
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(392, 429);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(92, 25);
            this.L_Password.TabIndex = 8;
            this.L_Password.Text = "password";
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Location = new System.Drawing.Point(421, 346);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(55, 25);
            this.L_Login.TabIndex = 7;
            this.L_Login.Text = "login";
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(490, 426);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(323, 33);
            this.TB_Password.TabIndex = 6;
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(490, 343);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(323, 33);
            this.TB_Login.TabIndex = 5;
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.Sign_Up);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Login);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Reg";
            this.Text = "Reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sign_Up;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_Login;
    }
}