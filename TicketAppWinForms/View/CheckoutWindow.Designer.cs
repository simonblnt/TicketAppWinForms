namespace TicketAppWinForms.View
{
    partial class CheckoutWindow
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
            this.LvCheckoutTicketList = new System.Windows.Forms.ListView();
            this.LblCheckoutTicketList = new System.Windows.Forms.Label();
            this.LblCheckoutFirstName = new System.Windows.Forms.Label();
            this.TbCheckoutFirstName = new System.Windows.Forms.TextBox();
            this.LblCheckoutLastName = new System.Windows.Forms.Label();
            this.TbCheckoutLastName = new System.Windows.Forms.TextBox();
            this.BtnCheckoutBack = new System.Windows.Forms.Button();
            this.BtnCheckoutPurchase = new System.Windows.Forms.Button();
            this.Sector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvCheckoutTicketList
            // 
            this.LvCheckoutTicketList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sector,
            this.Type,
            this.Price});
            this.LvCheckoutTicketList.FullRowSelect = true;
            this.LvCheckoutTicketList.GridLines = true;
            this.LvCheckoutTicketList.HideSelection = false;
            this.LvCheckoutTicketList.Location = new System.Drawing.Point(12, 108);
            this.LvCheckoutTicketList.Name = "LvCheckoutTicketList";
            this.LvCheckoutTicketList.Size = new System.Drawing.Size(300, 183);
            this.LvCheckoutTicketList.TabIndex = 0;
            this.LvCheckoutTicketList.UseCompatibleStateImageBehavior = false;
            // 
            // LblCheckoutTicketList
            // 
            this.LblCheckoutTicketList.AutoSize = true;
            this.LblCheckoutTicketList.Location = new System.Drawing.Point(9, 92);
            this.LblCheckoutTicketList.Name = "LblCheckoutTicketList";
            this.LblCheckoutTicketList.Size = new System.Drawing.Size(90, 13);
            this.LblCheckoutTicketList.TabIndex = 1;
            this.LblCheckoutTicketList.Text = "Selected Tickets:";
            // 
            // LblCheckoutFirstName
            // 
            this.LblCheckoutFirstName.AutoSize = true;
            this.LblCheckoutFirstName.Location = new System.Drawing.Point(9, 13);
            this.LblCheckoutFirstName.Name = "LblCheckoutFirstName";
            this.LblCheckoutFirstName.Size = new System.Drawing.Size(60, 13);
            this.LblCheckoutFirstName.TabIndex = 2;
            this.LblCheckoutFirstName.Text = "First Name:";
            // 
            // TbCheckoutFirstName
            // 
            this.TbCheckoutFirstName.Location = new System.Drawing.Point(12, 30);
            this.TbCheckoutFirstName.Name = "TbCheckoutFirstName";
            this.TbCheckoutFirstName.Size = new System.Drawing.Size(100, 20);
            this.TbCheckoutFirstName.TabIndex = 3;
            // 
            // LblCheckoutLastName
            // 
            this.LblCheckoutLastName.AutoSize = true;
            this.LblCheckoutLastName.Location = new System.Drawing.Point(9, 53);
            this.LblCheckoutLastName.Name = "LblCheckoutLastName";
            this.LblCheckoutLastName.Size = new System.Drawing.Size(61, 13);
            this.LblCheckoutLastName.TabIndex = 4;
            this.LblCheckoutLastName.Text = "Last Name:";
            // 
            // TbCheckoutLastName
            // 
            this.TbCheckoutLastName.Location = new System.Drawing.Point(12, 69);
            this.TbCheckoutLastName.Name = "TbCheckoutLastName";
            this.TbCheckoutLastName.Size = new System.Drawing.Size(100, 20);
            this.TbCheckoutLastName.TabIndex = 5;
            // 
            // BtnCheckoutBack
            // 
            this.BtnCheckoutBack.Location = new System.Drawing.Point(237, 27);
            this.BtnCheckoutBack.Name = "BtnCheckoutBack";
            this.BtnCheckoutBack.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckoutBack.TabIndex = 6;
            this.BtnCheckoutBack.Text = "Back";
            this.BtnCheckoutBack.UseVisualStyleBackColor = true;
            this.BtnCheckoutBack.Click += new System.EventHandler(this.BtnCheckoutBack_Click);
            // 
            // BtnCheckoutPurchase
            // 
            this.BtnCheckoutPurchase.Location = new System.Drawing.Point(237, 56);
            this.BtnCheckoutPurchase.Name = "BtnCheckoutPurchase";
            this.BtnCheckoutPurchase.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckoutPurchase.TabIndex = 7;
            this.BtnCheckoutPurchase.Text = "Purchase";
            this.BtnCheckoutPurchase.UseVisualStyleBackColor = true;
            this.BtnCheckoutPurchase.Click += new System.EventHandler(this.BtnCheckoutPurchase_Click);
            // 
            // CheckoutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 303);
            this.Controls.Add(this.BtnCheckoutPurchase);
            this.Controls.Add(this.BtnCheckoutBack);
            this.Controls.Add(this.TbCheckoutLastName);
            this.Controls.Add(this.LblCheckoutLastName);
            this.Controls.Add(this.TbCheckoutFirstName);
            this.Controls.Add(this.LblCheckoutFirstName);
            this.Controls.Add(this.LblCheckoutTicketList);
            this.Controls.Add(this.LvCheckoutTicketList);
            this.Name = "CheckoutWindow";
            this.Text = "CheckoutWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvCheckoutTicketList;
        private System.Windows.Forms.Label LblCheckoutTicketList;
        private System.Windows.Forms.Label LblCheckoutFirstName;
        private System.Windows.Forms.TextBox TbCheckoutFirstName;
        private System.Windows.Forms.Label LblCheckoutLastName;
        private System.Windows.Forms.TextBox TbCheckoutLastName;
        private System.Windows.Forms.Button BtnCheckoutBack;
        private System.Windows.Forms.Button BtnCheckoutPurchase;
        private System.Windows.Forms.ColumnHeader Sector;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Price;
    }
}