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
            this.manageAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadiumViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketListViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.shoppingCartViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMainUser = new System.Windows.Forms.Label();
            this.stadiumControl1 = new TicketAppWinForms.View.StadiumControl();
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
            this.ticketsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // manageAccountToolStripMenuItem
            // 
            this.manageAccountToolStripMenuItem.Name = "manageAccountToolStripMenuItem";
            this.manageAccountToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.manageAccountToolStripMenuItem.Text = "Manage Account";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stadiumViewToolStripMenuItem,
            this.ticketListViewToolStripMenuItem,
            this.toolStripSeparator2,
            this.shoppingCartViewToolStripMenuItem,
            this.purchaseHistoryToolStripMenuItem});
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ticketsToolStripMenuItem.Text = "View";
            // 
            // stadiumViewToolStripMenuItem
            // 
            this.stadiumViewToolStripMenuItem.Name = "stadiumViewToolStripMenuItem";
            this.stadiumViewToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.stadiumViewToolStripMenuItem.Text = "Stadium";
            // 
            // ticketListViewToolStripMenuItem
            // 
            this.ticketListViewToolStripMenuItem.Name = "ticketListViewToolStripMenuItem";
            this.ticketListViewToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ticketListViewToolStripMenuItem.Text = "Ticket List";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // shoppingCartViewToolStripMenuItem
            // 
            this.shoppingCartViewToolStripMenuItem.Name = "shoppingCartViewToolStripMenuItem";
            this.shoppingCartViewToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.shoppingCartViewToolStripMenuItem.Text = "Shopping Cart";
            // 
            // purchaseHistoryToolStripMenuItem
            // 
            this.purchaseHistoryToolStripMenuItem.Name = "purchaseHistoryToolStripMenuItem";
            this.purchaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purchaseHistoryToolStripMenuItem.Text = "Purchase History";
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
            this.lblMainUser.BackColor = System.Drawing.SystemColors.Window;
            this.lblMainUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMainUser.Location = new System.Drawing.Point(881, 9);
            this.lblMainUser.Name = "lblMainUser";
            this.lblMainUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMainUser.Size = new System.Drawing.Size(115, 13);
            this.lblMainUser.TabIndex = 9;
            this.lblMainUser.Text = "Guest";
            // 
            // stadiumControl1
            // 
            this.stadiumControl1.Location = new System.Drawing.Point(13, 28);
            this.stadiumControl1.Name = "stadiumControl1";
            this.stadiumControl1.Size = new System.Drawing.Size(983, 648);
            this.stadiumControl1.TabIndex = 10;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.stadiumControl1);
            this.Controls.Add(this.testMatchLabel);
            this.Controls.Add(this.lblMainUser);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
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
        private System.Windows.Forms.ToolStripMenuItem manageAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadiumViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketListViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem shoppingCartViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label lblMainUser;
        private System.Windows.Forms.Label testMatchLabel;
        private StadiumControl stadiumControl1;
    }
}