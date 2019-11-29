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
            this.BtnStadiumClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStadiumCheckout
            // 
            this.BtnStadiumCheckout.Location = new System.Drawing.Point(670, 141);
            this.BtnStadiumCheckout.Name = "BtnStadiumCheckout";
            this.BtnStadiumCheckout.Size = new System.Drawing.Size(86, 23);
            this.BtnStadiumCheckout.TabIndex = 0;
            this.BtnStadiumCheckout.Text = "To Checkout";
            this.BtnStadiumCheckout.UseVisualStyleBackColor = true;
            this.BtnStadiumCheckout.Click += new System.EventHandler(this.BtnStadiumCheckout_Click);
            // 
            // BtnStadiumClear
            // 
            this.BtnStadiumClear.Location = new System.Drawing.Point(654, 171);
            this.BtnStadiumClear.Name = "BtnStadiumClear";
            this.BtnStadiumClear.Size = new System.Drawing.Size(102, 23);
            this.BtnStadiumClear.TabIndex = 1;
            this.BtnStadiumClear.Text = "Clear Selections";
            this.BtnStadiumClear.UseVisualStyleBackColor = true;
            // 
            // StadiumControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnStadiumClear);
            this.Controls.Add(this.BtnStadiumCheckout);
            this.Location = new System.Drawing.Point(0, 23);
            this.Name = "StadiumControl";
            this.Size = new System.Drawing.Size(786, 426);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStadiumCheckout;
        private System.Windows.Forms.Button BtnStadiumClear;
    }
}
