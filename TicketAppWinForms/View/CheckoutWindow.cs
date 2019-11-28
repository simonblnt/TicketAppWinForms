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
    public partial class CheckoutWindow : Form
    {
        public Match Match { get; set; }
        public User User { get; set; }
        public List<Ticket> Tickets { get; set; }

        public CheckoutWindow(Match match, User user, List<Ticket> tickets)
        {
            InitializeComponent();
            Match = match;
            User = user;
            Tickets = tickets;
            this.TbCheckoutFirstName.Text = user.FirstName;
            this.TbCheckoutLastName.Text = user.LastName;
        }

        private void BtnCheckoutBack_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(Match, User);
            mainWindow.Show();
            this.Close();
        }

        private void BtnCheckoutPurchase_Click(object sender, EventArgs e)
        {
            //Change selected tickets to owned tickets
            foreach (var ticket in Tickets)
            {
                SqLite.BuyTicket(ticket.SeatId, ticket.MatchId);
            }

            //Update user
            User.FirstName = TbCheckoutFirstName.Text;
            User.LastName = TbCheckoutLastName.Text;
            SqLite.UpdateUser(User.Id, User.FirstName, User.LastName);

            MainWindow mainWindow = new MainWindow(Match, User);
            mainWindow.Show();
            this.Close();
        }

        private void LoadTicketsToListView()
        {
            /*  simple one-way, one-time binding 
                var myItems = new List<string> { "aaa", "bbb" };
                listBox1.DataSource = myItems;*/

            for (int i = 0; i < Tickets.Count; i++)
            {
                string seatName = SqLite.QuerySeatName(Tickets[i].SeatId);
                string ticketTypeName = SqLite.QueryTicketTypeName(Tickets[i].TicketTypeId);
                int ticketPrice = SqLite.QueryTicketPrice(Tickets[i].TicketTypeId);
                
                var ticketListView = new ListViewItem(new[] { seatName, ticketTypeName, ticketPrice.ToString() })
                {
                    Text = seatName,
                    Tag = Tickets
                };
                LvCheckoutTicketList.Items.Add(ticketListView);
            }

        }
    }
}
