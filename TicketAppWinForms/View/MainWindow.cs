using System;
using System.Windows.Forms;
using TicketAppWinForms.Model;

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
    }
}
