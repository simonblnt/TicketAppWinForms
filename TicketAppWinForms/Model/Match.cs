using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAppWinForms.Model
{
    public class Match
    {
        public int Id { get; set; }
        public string TeamHome { get; set; }
        public string TeamAway { get; set; }
        public int Income { get; set; }


        public Match(int id, string teamHome, string teamAway, int income) {
            Id = id;
            TeamHome = teamHome;
            TeamAway = teamAway;
            Income = income;
        }
    }
}
