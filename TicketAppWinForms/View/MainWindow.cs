using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.Model;

namespace TicketAppWinForms.View
{
    public partial class MainWindow : Form
    {
        private Match match;
        private User user;

        public MainWindow(Match match, User user)
        {
            InitializeComponent();
            this.user = user;
            this.match = match;
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
