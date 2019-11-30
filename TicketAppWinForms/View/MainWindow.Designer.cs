namespace TicketAppWinForms.View
{
    partial class MainWindow
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
            this.testMatchLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMainSelectMatch = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainUser = new System.Windows.Forms.Label();
            this.adminControl1 = new TicketAppWinForms.View.AdminControl();
            this.stadiumControl1 = new TicketAppWinForms.StadiumControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // testMatchLabel
            // 
            this.testMatchLabel.AutoSize = true;
            this.testMatchLabel.Location = new System.Drawing.Point(235, 9);
            this.testMatchLabel.Name = "testMatchLabel";
            this.testMatchLabel.Size = new System.Drawing.Size(35, 13);
            this.testMatchLabel.TabIndex = 0;
            this.testMatchLabel.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMainSelectMatch,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // ToolStripMenuItemMainSelectMatch
            // 
            this.ToolStripMenuItemMainSelectMatch.Name = "ToolStripMenuItemMainSelectMatch";
            this.ToolStripMenuItemMainSelectMatch.Size = new System.Drawing.Size(142, 22);
            this.ToolStripMenuItemMainSelectMatch.Text = "Select Match";
            this.ToolStripMenuItemMainSelectMatch.Click += new System.EventHandler(this.ToolStripMenuItemMainSelectMatch_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // lblMainUser
            // 
            this.lblMainUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMainUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMainUser.Location = new System.Drawing.Point(276, -123);
            this.lblMainUser.Name = "lblMainUser";
            this.lblMainUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMainUser.Size = new System.Drawing.Size(115, 13);
            this.lblMainUser.TabIndex = 9;
            this.lblMainUser.Text = "Guest";
            // 
            // adminControl1
            // 
            this.adminControl1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.adminControl1.Location = new System.Drawing.Point(779, 27);
            this.adminControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.adminControl1.Name = "adminControl1";
            this.adminControl1.Size = new System.Drawing.Size(329, 486);
            this.adminControl1.TabIndex = 12;
            // 
            // stadiumControl1
            // 
            this.stadiumControl1.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.stadiumControl1.Location = new System.Drawing.Point(0, 27);
            this.stadiumControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stadiumControl1.Match = null;
            this.stadiumControl1.Name = "stadiumControl1";
            this.stadiumControl1.Size = new System.Drawing.Size(768, 426);
            this.stadiumControl1.TabIndex = 11;
            this.stadiumControl1.User = null;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1108, 485);
            this.Controls.Add(this.adminControl1);
            this.Controls.Add(this.stadiumControl1);
            this.Controls.Add(this.testMatchLabel);
            this.Controls.Add(this.lblMainUser);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1124, 524);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1124, 524);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMainSelectMatch;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label lblMainUser;
        private System.Windows.Forms.Label testMatchLabel;
        private StadiumControl stadiumControl1;
        private AdminControl adminControl1;
    }
}