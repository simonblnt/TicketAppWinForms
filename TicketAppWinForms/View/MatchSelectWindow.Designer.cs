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
            this.matchSelectBtnOk = new System.Windows.Forms.Button();
            this.matchSelectLblWelcome = new System.Windows.Forms.Label();
            this.matchSelectLvMatches = new System.Windows.Forms.ListView();
            this.HomeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AwayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // matchSelectBtnOk
            // 
            this.matchSelectBtnOk.Location = new System.Drawing.Point(357, 60);
            this.matchSelectBtnOk.Name = "matchSelectBtnOk";
            this.matchSelectBtnOk.Size = new System.Drawing.Size(75, 23);
            this.matchSelectBtnOk.TabIndex = 3;
            this.matchSelectBtnOk.Text = "Select";
            this.matchSelectBtnOk.UseVisualStyleBackColor = true;
            this.matchSelectBtnOk.Click += new System.EventHandler(this.BtnMatchSelectOk_Click);
            // 
            // matchSelectLblWelcome
            // 
            this.matchSelectLblWelcome.AutoSize = true;
            this.matchSelectLblWelcome.Location = new System.Drawing.Point(12, 23);
            this.matchSelectLblWelcome.Name = "matchSelectLblWelcome";
            this.matchSelectLblWelcome.Size = new System.Drawing.Size(86, 13);
            this.matchSelectLblWelcome.TabIndex = 5;
            this.matchSelectLblWelcome.Text = "Welcome Guest!";
            // 
            // matchSelectLvMatches
            // 
            this.matchSelectLvMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HomeColumn,
            this.AwayColumn});
            this.matchSelectLvMatches.FullRowSelect = true;
            this.matchSelectLvMatches.HideSelection = false;
            this.matchSelectLvMatches.Location = new System.Drawing.Point(12, 60);
            this.matchSelectLvMatches.MultiSelect = false;
            this.matchSelectLvMatches.Name = "matchSelectLvMatches";
            this.matchSelectLvMatches.Size = new System.Drawing.Size(339, 154);
            this.matchSelectLvMatches.TabIndex = 6;
            this.matchSelectLvMatches.UseCompatibleStateImageBehavior = false;
            this.matchSelectLvMatches.View = System.Windows.Forms.View.Details;
            // 
            // HomeColumn
            // 
            this.HomeColumn.Text = "Home";
            this.HomeColumn.Width = 160;
            // 
            // AwayColumn
            // 
            this.AwayColumn.Text = "Away";
            this.AwayColumn.Width = 160;
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(TicketAppWinForms.Model.Match);
            // 
            // MatchSelectWindow
            // 
            this.AcceptButton = this.matchSelectBtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 226);
            this.Controls.Add(this.matchSelectLvMatches);
            this.Controls.Add(this.matchSelectLblWelcome);
            this.Controls.Add(this.matchSelectBtnOk);
            this.Name = "MatchSelectWindow";
            this.Text = "MatchSelectWindow";
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button matchSelectBtnOk;
        private System.Windows.Forms.Label matchSelectLblWelcome;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.ListView matchSelectLvMatches;
        private System.Windows.Forms.ColumnHeader HomeColumn;
        private System.Windows.Forms.ColumnHeader AwayColumn;
    }
}