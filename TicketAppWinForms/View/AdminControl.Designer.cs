namespace TicketAppWinForms.View
{
    partial class AdminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LvAdminTicketsAll = new System.Windows.Forms.ListView();
            this.LblAdminIncome = new System.Windows.Forms.Label();
            this.TextAdminIncome = new System.Windows.Forms.Label();
            this.LvAdminTicketsByType = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Seat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LvAdminTicketsAll
            // 
            this.LvAdminTicketsAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Seat,
            this.User,
            this.Price});
            this.LvAdminTicketsAll.HideSelection = false;
            this.LvAdminTicketsAll.Location = new System.Drawing.Point(4, 4);
            this.LvAdminTicketsAll.Name = "LvAdminTicketsAll";
            this.LvAdminTicketsAll.Size = new System.Drawing.Size(239, 306);
            this.LvAdminTicketsAll.TabIndex = 0;
            this.LvAdminTicketsAll.UseCompatibleStateImageBehavior = false;
            this.LvAdminTicketsAll.View = System.Windows.Forms.View.Details;
            // 
            // LblAdminIncome
            // 
            this.LblAdminIncome.AutoSize = true;
            this.LblAdminIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblAdminIncome.Location = new System.Drawing.Point(3, 425);
            this.LblAdminIncome.Name = "LblAdminIncome";
            this.LblAdminIncome.Size = new System.Drawing.Size(154, 26);
            this.LblAdminIncome.TabIndex = 1;
            this.LblAdminIncome.Text = "Match income:";
            // 
            // TextAdminIncome
            // 
            this.TextAdminIncome.AutoSize = true;
            this.TextAdminIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextAdminIncome.Location = new System.Drawing.Point(163, 425);
            this.TextAdminIncome.Name = "TextAdminIncome";
            this.TextAdminIncome.Size = new System.Drawing.Size(0, 26);
            this.TextAdminIncome.TabIndex = 2;
            // 
            // LvAdminTicketsByType
            // 
            this.LvAdminTicketsByType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Income});
            this.LvAdminTicketsByType.HideSelection = false;
            this.LvAdminTicketsByType.Location = new System.Drawing.Point(4, 316);
            this.LvAdminTicketsByType.Name = "LvAdminTicketsByType";
            this.LvAdminTicketsByType.Size = new System.Drawing.Size(239, 97);
            this.LvAdminTicketsByType.TabIndex = 3;
            this.LvAdminTicketsByType.UseCompatibleStateImageBehavior = false;
            this.LvAdminTicketsByType.View = System.Windows.Forms.View.Details;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 74;
            // 
            // Seat
            // 
            this.Seat.Text = "Seat";
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 81;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 71;
            // 
            // Income
            // 
            this.Income.Text = "Income";
            this.Income.Width = 142;
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LvAdminTicketsByType);
            this.Controls.Add(this.TextAdminIncome);
            this.Controls.Add(this.LblAdminIncome);
            this.Controls.Add(this.LvAdminTicketsAll);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(252, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LvAdminTicketsAll;
        private System.Windows.Forms.ColumnHeader Seat;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Label LblAdminIncome;
        private System.Windows.Forms.Label TextAdminIncome;
        private System.Windows.Forms.ListView LvAdminTicketsByType;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Income;
    }
}
