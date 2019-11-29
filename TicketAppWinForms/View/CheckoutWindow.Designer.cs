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
            this.components = new System.ComponentModel.Container();
            this.LblCheckoutTicketList = new System.Windows.Forms.Label();
            this.LblCheckoutFirstName = new System.Windows.Forms.Label();
            this.TbCheckoutFirstName = new System.Windows.Forms.TextBox();
            this.LblCheckoutLastName = new System.Windows.Forms.Label();
            this.TbCheckoutLastName = new System.Windows.Forms.TextBox();
            this.BtnCheckoutBack = new System.Windows.Forms.Button();
            this.BtnCheckoutPurchase = new System.Windows.Forms.Button();
            this.LvCheckoutTickets = new System.Windows.Forms.ListView();
            this.Seat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LblCheckoutPrice = new System.Windows.Forms.Label();
            this.TextCheckoutPrice = new System.Windows.Forms.Label();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.BtnCheckoutBack.Location = new System.Drawing.Point(238, 27);
            this.BtnCheckoutBack.Name = "BtnCheckoutBack";
            this.BtnCheckoutBack.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckoutBack.TabIndex = 6;
            this.BtnCheckoutBack.Text = "Back";
            this.BtnCheckoutBack.UseVisualStyleBackColor = true;
            this.BtnCheckoutBack.Click += new System.EventHandler(this.BtnCheckoutBack_Click);
            // 
            // BtnCheckoutPurchase
            // 
            this.BtnCheckoutPurchase.Location = new System.Drawing.Point(238, 66);
            this.BtnCheckoutPurchase.Name = "BtnCheckoutPurchase";
            this.BtnCheckoutPurchase.Size = new System.Drawing.Size(75, 23);
            this.BtnCheckoutPurchase.TabIndex = 7;
            this.BtnCheckoutPurchase.Text = "Purchase";
            this.BtnCheckoutPurchase.UseVisualStyleBackColor = true;
            this.BtnCheckoutPurchase.Click += new System.EventHandler(this.BtnCheckoutPurchase_Click);
            // 
            // LvCheckoutTickets
            // 
            this.LvCheckoutTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Seat,
            this.Type,
            this.Price});
            this.LvCheckoutTickets.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LvCheckoutTickets.FullRowSelect = true;
            this.LvCheckoutTickets.HideSelection = false;
            this.LvCheckoutTickets.Location = new System.Drawing.Point(13, 109);
            this.LvCheckoutTickets.Name = "LvCheckoutTickets";
            this.LvCheckoutTickets.Size = new System.Drawing.Size(300, 182);
            this.LvCheckoutTickets.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LvCheckoutTickets.TabIndex = 8;
            this.LvCheckoutTickets.UseCompatibleStateImageBehavior = false;
            this.LvCheckoutTickets.View = System.Windows.Forms.View.Details;
            this.LvCheckoutTickets.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Seat
            // 
            this.Seat.Text = "Seat";
            this.Seat.Width = 83;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 85;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 83;
            // 
            // LblCheckoutPrice
            // 
            this.LblCheckoutPrice.AutoSize = true;
            this.LblCheckoutPrice.Location = new System.Drawing.Point(119, 13);
            this.LblCheckoutPrice.Name = "LblCheckoutPrice";
            this.LblCheckoutPrice.Size = new System.Drawing.Size(34, 13);
            this.LblCheckoutPrice.TabIndex = 9;
            this.LblCheckoutPrice.Text = "Price:";
            // 
            // TextCheckoutPrice
            // 
            this.TextCheckoutPrice.AutoSize = true;
            this.TextCheckoutPrice.Location = new System.Drawing.Point(122, 36);
            this.TextCheckoutPrice.Name = "TextCheckoutPrice";
            this.TextCheckoutPrice.Size = new System.Drawing.Size(0, 13);
            this.TextCheckoutPrice.TabIndex = 10;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(TicketAppWinForms.Model.Ticket);
            // 
            // CheckoutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 303);
            this.Controls.Add(this.TextCheckoutPrice);
            this.Controls.Add(this.LblCheckoutPrice);
            this.Controls.Add(this.LvCheckoutTickets);
            this.Controls.Add(this.BtnCheckoutPurchase);
            this.Controls.Add(this.BtnCheckoutBack);
            this.Controls.Add(this.TbCheckoutLastName);
            this.Controls.Add(this.LblCheckoutLastName);
            this.Controls.Add(this.TbCheckoutFirstName);
            this.Controls.Add(this.LblCheckoutFirstName);
            this.Controls.Add(this.LblCheckoutTicketList);
            this.Name = "CheckoutWindow";
            this.Text = "CheckoutWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblCheckoutTicketList;
        private System.Windows.Forms.Label LblCheckoutFirstName;
        private System.Windows.Forms.TextBox TbCheckoutFirstName;
        private System.Windows.Forms.Label LblCheckoutLastName;
        private System.Windows.Forms.TextBox TbCheckoutLastName;
        private System.Windows.Forms.Button BtnCheckoutBack;
        private System.Windows.Forms.Button BtnCheckoutPurchase;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.ListView LvCheckoutTickets;
        private System.Windows.Forms.ColumnHeader Seat;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label LblCheckoutPrice;
        private System.Windows.Forms.Label TextCheckoutPrice;
    }
}