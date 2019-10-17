using System;
using System.Collections.Generic;
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
            LoadMatchesToListView();
            this.user = user;
            matchSelectLblWelcome.Text = "Welcome " + user.LastName + " " + user.FirstName + "!";
        }

        private void Matches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadMatchesToListView()
        {
            List<Match> MatchesList = SqLite.QueryListOfMatches();
            
            for (int i = 0; i < MatchesList.Count; i++)
            {
                var match = new ListViewItem(new[] { MatchesList[i].TeamHome, MatchesList[i].TeamAway })
                {
                    Text = MatchesList[i].TeamHome,
                    Tag = MatchesList
                };
                matchSelectLvMatches.Items.Add(match);
            }
        }

        private void BtnMatchSelectOk_Click(object sender, EventArgs e)
        {
            if (matchSelectLvMatches.SelectedItems.Count == 1)
            {
                var homeTeam = matchSelectLvMatches.SelectedItems[0].SubItems[0].ToString();
                var awayTeam = matchSelectLvMatches.SelectedItems[0].SubItems[1].ToString();
                Match match = new Match(0, homeTeam, awayTeam, 20);
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
