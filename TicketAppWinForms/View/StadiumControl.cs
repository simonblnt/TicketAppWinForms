using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.Controller;
using TicketAppWinForms.Model;
using TicketAppWinForms.View;
using TicketAppWinForms.DataAccess;

namespace TicketAppWinForms
{
    public partial class StadiumControl : UserControl
    {
        public Match Match { get; set; }
        public User User { get; set; }
        private StadiumControlController stadiumController;
        public StadiumControl()
        {
            InitializeComponent();
        }

        public void InitStadium(Match match, User user) {
            Match = match;
            User = user;
            stadiumController = new StadiumControlController(this, Match, User);
        }

        private void BtnStadiumCheckout_Click(object sender, EventArgs e)
        {
            stadiumController.OpenCheckoutWindow();
        }
    }
}
