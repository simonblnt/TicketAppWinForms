using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.DataAccess;
using TicketAppWinForms.Model;

namespace TicketAppWinForms.View
{
    public partial class MatchSelectWindow : Form
    {
        private User user;

        public MatchSelectWindow(User user)
        {
            InitializeComponent();
            LoadMatchesToListBox();
            this.user = user;
            lblMatchSelectWelcome.Text = "Welcome " + user.LastName + " " + user.FirstName + "!";
        }

        private void Matches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadMatchesToListBox()
        {
            List<Match> MatchesList = SqLite.QueryListOfMatches();


            //lbMatchSelectMatches.Items.Add(String.Format("{0}\t{1}", match.TeamHome, match.TeamAway));
            lbMatchSelectMatches.ValueMember = "Id";
            lbMatchSelectMatches.DisplayMember = "TeamHome";
            
            lbMatchSelectMatches.DataSource = MatchesList;
        }

        private void BtnMatchSelectOk_Click(object sender, EventArgs e)
        {
            if (lbMatchSelectMatches.SelectedItems.Count == 1)
            {
                Match match = (Match)lbMatchSelectMatches.SelectedItem;
                MainWindow mainWindow = new MainWindow(match, user);
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Select a match!");
            }
        }

        private void lbMatchSelectMatches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
