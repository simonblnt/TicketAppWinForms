namespace TicketAppWinForms.View
{
    partial class MatchSelectWindow
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
            this.lbMatchSelectMatches = new System.Windows.Forms.ListBox();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMatchSelectOk = new System.Windows.Forms.Button();
            this.lblMatchSelectWelcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMatchSelectMatches
            // 
            this.lbMatchSelectMatches.DataSource = this.matchBindingSource;
            this.lbMatchSelectMatches.DisplayMember = "TeamHome";
            this.lbMatchSelectMatches.FormattingEnabled = true;
            this.lbMatchSelectMatches.Location = new System.Drawing.Point(12, 60);
            this.lbMatchSelectMatches.MultiColumn = true;
            this.lbMatchSelectMatches.Name = "lbMatchSelectMatches";
            this.lbMatchSelectMatches.Size = new System.Drawing.Size(338, 95);
            this.lbMatchSelectMatches.TabIndex = 2;
            this.lbMatchSelectMatches.ValueMember = "TeamAway";
            this.lbMatchSelectMatches.SelectedIndexChanged += new System.EventHandler(this.lbMatchSelectMatches_SelectedIndexChanged);
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(TicketAppWinForms.Model.Match);
            // 
            // btnMatchSelectOk
            // 
            this.btnMatchSelectOk.Location = new System.Drawing.Point(357, 60);
            this.btnMatchSelectOk.Name = "btnMatchSelectOk";
            this.btnMatchSelectOk.Size = new System.Drawing.Size(75, 23);
            this.btnMatchSelectOk.TabIndex = 3;
            this.btnMatchSelectOk.Text = "Select";
            this.btnMatchSelectOk.UseVisualStyleBackColor = true;
            this.btnMatchSelectOk.Click += new System.EventHandler(this.BtnMatchSelectOk_Click);
            // 
            // lblMatchSelectWelcome
            // 
            this.lblMatchSelectWelcome.AutoSize = true;
            this.lblMatchSelectWelcome.Location = new System.Drawing.Point(12, 9);
            this.lblMatchSelectWelcome.Name = "lblMatchSelectWelcome";
            this.lblMatchSelectWelcome.Size = new System.Drawing.Size(86, 13);
            this.lblMatchSelectWelcome.TabIndex = 5;
            this.lblMatchSelectWelcome.Text = "Welcome Guest!";
            // 
            // MatchSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 226);
            this.Controls.Add(this.lblMatchSelectWelcome);
            this.Controls.Add(this.btnMatchSelectOk);
            this.Controls.Add(this.lbMatchSelectMatches);
            this.Name = "MatchSelectWindow";
            this.Text = "MatchSelectWindow";
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMatchSelectMatches;
        private System.Windows.Forms.Button btnMatchSelectOk;
        private System.Windows.Forms.Label lblMatchSelectWelcome;
        private System.Windows.Forms.BindingSource matchBindingSource;
    }
}