using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.Model;
using TicketAppWinForms.Controller;
using TicketAppWinForms.DataAccess;

namespace TicketAppWinForms.View
{
    public partial class AdminControl : UserControl
    {
        private AdminControlController adminControlController;
        private Match match;
        private List<Ticket> tickets;
        private List<TicketType> ticketTypes;

        public AdminControl()
        {
            InitializeComponent();
            adminControlController = new AdminControlController(this);
        }

        public void InitAdmin(Match match)
        {
            this.match = match;
            ticketTypes = SqLite.QueryTicketTypes();
            tickets = SqLite.QueryOwnedTickets(match.Id);
            TextAdminIncome.Text = SqLite.CalculateMatchIncome(match.Id).ToString();
            LoadTicketsToListViewAll();
            LoadTicketToListViewByType();
        }

        private void LoadTicketsToListViewAll()
        {
            for (int i = 0; i < tickets.Count; i++)
            {
                string fullName = SqLite.QueryUserFullName(tickets[i].UserId); //ki
                string seatName = SqLite.QuerySeatName(tickets[i].SeatId); //hova
                int ticketPrice = SqLite.QueryTicketPrice(tickets[i].TicketTypeId); // milyen ertekben

                var ticketListView = new ListViewItem(new[] { seatName, fullName, ticketPrice.ToString() });

                LvAdminTicketsAll.Items.Add(ticketListView);
            }
        }

        private void LoadTicketToListViewByType()
        {
            for (int i = 0; i < ticketTypes.Count; i++)
            {
                string typeName = ticketTypes[i].Name;
                int income = 0;

                int numberOfTickets = SqLite.QueryNumberOfTicketsByType(match.Id, ticketTypes[i].Id);
                for (int j = 0; j < numberOfTickets; j++)
                {
                    income += ticketTypes[i].Price;
                }

                 SqLite.QueryTicketPrice(tickets[i].TicketTypeId); // milyen ertekben

                var ticketListView = new ListViewItem(new[] { typeName, income.ToString() });

                LvAdminTicketsByType.Items.Add(ticketListView);
            }
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }
    }
}
