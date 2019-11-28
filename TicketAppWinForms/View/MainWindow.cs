using System;
using System.Windows.Forms;
using TicketAppWinForms.Model;
using System.Data;
using System.Data.SQLite;

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
    }
}
