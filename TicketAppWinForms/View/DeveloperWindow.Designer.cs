namespace TicketAppWinForms.View
{
    partial class DeveloperWindow
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
            this.BtnDevBack = new System.Windows.Forms.Button();
            this.BtnDevGenerateTickets = new System.Windows.Forms.Button();
            this.BtnDevLoadData = new System.Windows.Forms.Button();
            this.BtnDevClearData = new System.Windows.Forms.Button();
            this.BtnDevConnectionState = new System.Windows.Forms.Button();
            this.BtnDevConnect = new System.Windows.Forms.Button();
            this.BtnDevDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDevBack
            // 
            this.BtnDevBack.Location = new System.Drawing.Point(13, 13);
            this.BtnDevBack.Name = "BtnDevBack";
            this.BtnDevBack.Size = new System.Drawing.Size(75, 23);
            this.BtnDevBack.TabIndex = 0;
            this.BtnDevBack.Text = "Back";
            this.BtnDevBack.UseVisualStyleBackColor = true;
            this.BtnDevBack.Click += new System.EventHandler(this.BtnDevBack_Click);
            // 
            // BtnDevGenerateTickets
            // 
            this.BtnDevGenerateTickets.Location = new System.Drawing.Point(256, 13);
            this.BtnDevGenerateTickets.Name = "BtnDevGenerateTickets";
            this.BtnDevGenerateTickets.Size = new System.Drawing.Size(102, 23);
            this.BtnDevGenerateTickets.TabIndex = 1;
            this.BtnDevGenerateTickets.Text = "Generate Tickets";
            this.BtnDevGenerateTickets.UseVisualStyleBackColor = true;
            this.BtnDevGenerateTickets.Click += new System.EventHandler(this.BtnDevGenerateTickets_Click);
            // 
            // BtnDevLoadData
            // 
            this.BtnDevLoadData.Location = new System.Drawing.Point(175, 13);
            this.BtnDevLoadData.Name = "BtnDevLoadData";
            this.BtnDevLoadData.Size = new System.Drawing.Size(75, 23);
            this.BtnDevLoadData.TabIndex = 2;
            this.BtnDevLoadData.Text = "Load Data";
            this.BtnDevLoadData.UseVisualStyleBackColor = true;
            this.BtnDevLoadData.Click += new System.EventHandler(this.BtnDevLoadData_Click);
            // 
            // BtnDevClearData
            // 
            this.BtnDevClearData.Location = new System.Drawing.Point(94, 13);
            this.BtnDevClearData.Name = "BtnDevClearData";
            this.BtnDevClearData.Size = new System.Drawing.Size(75, 23);
            this.BtnDevClearData.TabIndex = 3;
            this.BtnDevClearData.Text = "Clear Data";
            this.BtnDevClearData.UseVisualStyleBackColor = true;
            this.BtnDevClearData.Click += new System.EventHandler(this.BtnDevClearData_Click);
            // 
            // BtnDevConnectionState
            // 
            this.BtnDevConnectionState.Location = new System.Drawing.Point(13, 62);
            this.BtnDevConnectionState.Name = "BtnDevConnectionState";
            this.BtnDevConnectionState.Size = new System.Drawing.Size(104, 23);
            this.BtnDevConnectionState.TabIndex = 4;
            this.BtnDevConnectionState.Text = "Connection State";
            this.BtnDevConnectionState.UseVisualStyleBackColor = true;
            this.BtnDevConnectionState.Click += new System.EventHandler(this.BtnDevConnectionState_Click);
            // 
            // BtnDevConnect
            // 
            this.BtnDevConnect.Location = new System.Drawing.Point(123, 62);
            this.BtnDevConnect.Name = "BtnDevConnect";
            this.BtnDevConnect.Size = new System.Drawing.Size(91, 23);
            this.BtnDevConnect.TabIndex = 5;
            this.BtnDevConnect.Text = "Connect to Db";
            this.BtnDevConnect.UseVisualStyleBackColor = true;
            this.BtnDevConnect.Click += new System.EventHandler(this.BtnDevConnect_Click);
            // 
            // BtnDevDisconnect
            // 
            this.BtnDevDisconnect.Location = new System.Drawing.Point(220, 62);
            this.BtnDevDisconnect.Name = "BtnDevDisconnect";
            this.BtnDevDisconnect.Size = new System.Drawing.Size(120, 23);
            this.BtnDevDisconnect.TabIndex = 6;
            this.BtnDevDisconnect.Text = "Disconnect from Db";
            this.BtnDevDisconnect.UseVisualStyleBackColor = true;
            this.BtnDevDisconnect.Click += new System.EventHandler(this.BtnDevDisconnect_Click);
            // 
            // DeveloperWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 196);
            this.Controls.Add(this.BtnDevDisconnect);
            this.Controls.Add(this.BtnDevConnect);
            this.Controls.Add(this.BtnDevConnectionState);
            this.Controls.Add(this.BtnDevClearData);
            this.Controls.Add(this.BtnDevLoadData);
            this.Controls.Add(this.BtnDevGenerateTickets);
            this.Controls.Add(this.BtnDevBack);
            this.Name = "DeveloperWindow";
            this.Text = "DeveloperWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDevBack;
        private System.Windows.Forms.Button BtnDevGenerateTickets;
        private System.Windows.Forms.Button BtnDevLoadData;
        private System.Windows.Forms.Button BtnDevClearData;
        private System.Windows.Forms.Button BtnDevConnectionState;
        private System.Windows.Forms.Button BtnDevConnect;
        private System.Windows.Forms.Button BtnDevDisconnect;
    }
}