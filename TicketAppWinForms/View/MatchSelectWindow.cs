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
                var matchListView = new ListViewItem(new[] { MatchesList[i].TeamHome, MatchesList[i].TeamAway })
                {
                    Text = MatchesList[i].TeamHome,
                    Tag = MatchesList
                };
                matchSelectLvMatches.Items.Add(matchListView);
            }
        }

        private void BtnMatchSelectOk_Click(object sender, EventArgs e)
        {
            if (matchSelectLvMatches.SelectedItems.Count == 1)
            {
                string homeTeam = matchSelectLvMatches.SelectedItems[0].SubItems[0].Text.ToString();
                string awayTeam = matchSelectLvMatches.SelectedItems[0].SubItems[1].Text.ToString();


                int id = SqLite.QueryMatchId(homeTeam, awayTeam);
                int income = SqLite.QueryMatchIncome(id);
                Match match = new Match(id, homeTeam, awayTeam, income);
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
