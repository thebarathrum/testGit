namespace test_Klyuev_Alexander
{
    partial class Auth
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
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.L_Login = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.L_Reg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(485, 638);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(323, 33);
            this.TB_Login.TabIndex = 0;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(485, 721);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(323, 33);
            this.TB_Password.TabIndex = 1;
            // 
            // L_Login
            // 
            this.L_Login.AutoSize = true;
            this.L_Login.Location = new System.Drawing.Point(416, 641);
            this.L_Login.Name = "L_Login";
            this.L_Login.Size = new System.Drawing.Size(55, 25);
            this.L_Login.TabIndex = 2;
            this.L_Login.Text = "login";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Location = new System.Drawing.Point(387, 724);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(92, 25);
            this.L_Password.TabIndex = 3;
            this.L_Password.Text = "password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 779);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Auth_Click);
            // 
            // L_Reg
            // 
            this.L_Reg.AutoSize = true;
            this.L_Reg.Location = new System.Drawing.Point(495, 835);
            this.L_Reg.Name = "L_Reg";
            this.L_Reg.Size = new System.Drawing.Size(302, 25);
            this.L_Reg.TabIndex = 5;
            this.L_Reg.TabStop = true;
            this.L_Reg.Text = "Don\'t you have an user accoount ?";
            this.L_Reg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.L_Reg_LinkClicked);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.L_Reg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_Login);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Login);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label L_Login;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel L_Reg;
    }
}