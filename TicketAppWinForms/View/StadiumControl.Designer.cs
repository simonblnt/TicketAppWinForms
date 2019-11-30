namespace TicketAppWinForms
{
    partial class StadiumControl
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
            this.BtnStadiumCheckout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStadiumCheckout
            // 
            this.BtnStadiumCheckout.Location = new System.Drawing.Point(485, 3);
            this.BtnStadiumCheckout.Name = "BtnStadiumCheckout";
            this.BtnStadiumCheckout.Size = new System.Drawing.Size(86, 23);
            this.BtnStadiumCheckout.TabIndex = 0;
            this.BtnStadiumCheckout.Text = "To Checkout";
            this.BtnStadiumCheckout.UseVisualStyleBackColor = true;
            this.BtnStadiumCheckout.Click += new System.EventHandler(this.BtnStadiumCheckout_Click);
            // 
            // StadiumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnStadiumCheckout);
            this.Name = "StadiumControl";
            this.Size = new System.Drawing.Size(574, 354);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStadiumCheckout;
    }
}
