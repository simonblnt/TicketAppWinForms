using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            LoadTicketsToListView();
        }

        private void BtnCheckoutBack_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow(Match, User);
            mainWindow.Show();
            this.Close();
        }

        private void BtnCheckoutPurchase_Click(object sender, EventArgs e)
        {
            string emailContent = "";
            int incomeGenerated = 0;
            //Change selected tickets to owned tickets
            foreach (var ticket in Tickets)
            {
                emailContent += "Seat: " + ticket.SeatId + " Type: " + ticket.TicketTypeId;
                SqLite.BuyTicket(ticket.SeatId, ticket.MatchId);
                int income = SqLite.QueryTicketPrice(ticket.TicketTypeId);
                incomeGenerated += income;
            }

            //Update user
            User.FirstName = TbCheckoutFirstName.Text;
            User.LastName = TbCheckoutLastName.Text;
            SqLite.UpdateUser(User.Id, User.FirstName, User.LastName);

            //Update match income
            SqLite.IncreaseIncome(incomeGenerated, Match.Id);

            //Send email
            SendEmail(emailContent);

            MainWindow mainWindow = new MainWindow(Match, User);
            mainWindow.Show();
            this.Close();
        }

        private void LoadTicketsToListView()
        {
            int priceSum = 0;
            for (int i = 0; i < Tickets.Count; i++)
            {
                string seatName = SqLite.QuerySeatName(Tickets[i].SeatId);
                string ticketTypeName = SqLite.QueryTicketTypeName(Tickets[i].TicketTypeId);
                int ticketPrice = SqLite.QueryTicketPrice(Tickets[i].TicketTypeId);
                priceSum += ticketPrice;
                var ticketListView = new ListViewItem(new[] { seatName, ticketTypeName, ticketPrice.ToString() });
                Console.WriteLine();
                LvCheckoutTickets.Items.Add(ticketListView);
            }
            TextCheckoutPrice.Text = priceSum.ToString() + " Ft";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SendEmail(string content)
        {
            string emailFrom = "csharpticketsender@gmail.com";
            string emailFromPassword = "Admin123.";
            string emailTo = "simon.blnt93@gmail.com";
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress(emailFrom);
            message.To.Add(new MailAddress(emailTo));
            message.Subject = "Ticket";
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = content;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emailFrom, emailFromPassword);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
    }
}
