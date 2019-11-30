using System;
using System.Windows.Forms;
using TicketAppWinForms.Model;
using System.Data;
using System.Data.SQLite;
using TicketAppWinForms.DataAccess;
using System.Drawing;

namespace TicketAppWinForms.View
{
    public partial class MainWindow : Form
    {
        public Match match;
        private User user;

        public MainWindow(Match match, User user)
        {
            this.user = user;
            this.match = match;
            

            InitializeComponent();

            if (SqLite.IsAdmin(user.Id))
            {
                int sizeX = 1124;
                int sizeY = 524;
                this.MinimumSize = new Size(sizeX, sizeY);
                this.Size = new Size(sizeX, sizeY);
                this.MaximumSize = new Size(sizeX, sizeY);
                adminControl1.InitAdmin(match);
            }
            else
            {
                adminControl1.Hide();
                int sizeX = 794;
                int sizeY = 524;
                this.MinimumSize = new Size(sizeX, sizeY);
                this.Size = new Size(sizeX, sizeY);
                this.MaximumSize = new Size(sizeX, sizeY);
            }

            stadiumControl1.InitStadium(match, user);

            lblMainUser.Text = "Logged in as: " + user.AccountName;
            testMatchLabel.Text = match.TeamHome + " " + match.TeamAway;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void ToolStripMenuItemMainSelectMatch_Click(object sender, EventArgs e)
        {
            MatchSelectWindow matchSelectWindow = new MatchSelectWindow(user);
            matchSelectWindow.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
