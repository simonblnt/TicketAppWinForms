namespace TicketAppWinForms.View
{
    partial class LoginWindow
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
            this.btnLoginLoadDefaultData = new System.Windows.Forms.Button();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.tbLoginUsername = new System.Windows.Forms.TextBox();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginLoadDefaultData
            // 
            this.btnLoginLoadDefaultData.Location = new System.Drawing.Point(12, 12);
            this.btnLoginLoadDefaultData.Name = "btnLoginLoadDefaultData";
            this.btnLoginLoadDefaultData.Size = new System.Drawing.Size(75, 23);
            this.btnLoginLoadDefaultData.TabIndex = 0;
            this.btnLoginLoadDefaultData.Text = "Load Data";
            this.btnLoginLoadDefaultData.UseVisualStyleBackColor = true;
            this.btnLoginLoadDefaultData.Click += new System.EventHandler(this.BtnLoadDefaultData_Click);
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Location = new System.Drawing.Point(60, 88);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(58, 13);
            this.lblLoginUsername.TabIndex = 1;
            this.lblLoginUsername.Text = "Username:";
            this.lblLoginUsername.Click += new System.EventHandler(this.LblLoginUsername_Click);
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Location = new System.Drawing.Point(60, 114);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(56, 13);
            this.lblLoginPassword.TabIndex = 2;
            this.lblLoginPassword.Text = "Password:";
            // 
            // tbLoginUsername
            // 
            this.tbLoginUsername.Location = new System.Drawing.Point(124, 85);
            this.tbLoginUsername.Name = "tbLoginUsername";
            this.tbLoginUsername.Size = new System.Drawing.Size(100, 20);
            this.tbLoginUsername.TabIndex = 3;
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(124, 111);
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.tbLoginPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(255, 88);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 176);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.tbLoginUsername);
            this.Controls.Add(this.lblLoginPassword);
            this.Controls.Add(this.lblLoginUsername);
            this.Controls.Add(this.btnLoginLoadDefaultData);
            this.Name = "LoginWindow";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoginLoadDefaultData;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.TextBox tbLoginUsername;
        private System.Windows.Forms.TextBox tbLoginPassword;
        private System.Windows.Forms.Button btnLogin;
    }
}

