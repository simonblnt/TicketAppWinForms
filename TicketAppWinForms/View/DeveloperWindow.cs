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

namespace TicketAppWinForms.View
{
    public partial class DeveloperWindow : Form
    {
        public DeveloperWindow()
        {
            InitializeComponent();
        }

        private void BtnDevBack_Click(object sender, EventArgs e)
        {
            var loginWindow = new LoginWindow();
            this.Close();
            loginWindow.Show();
        }

        private void BtnDevClearData_Click(object sender, EventArgs e)
        {
            string message = "Data Cleared";
            SqLite.ClearData();
            MessageBox.Show(message);
        }

        private void BtnDevLoadData_Click(object sender, EventArgs e)
        {
            string message = "Data Loaded";
            SqLite.LoadDefaultData();
            MessageBox.Show(message);
        }

        private void BtnDevConnectionState_Click(object sender, EventArgs e)
        {
            string state;
            if (SqLite.IsConnected() == true)
                state = "Connected";
            else
                state = "Disconnected";

            MessageBox.Show(state);
        }

        private void BtnDevConnect_Click(object sender, EventArgs e)
        {
            string message = "Connected to Database";
            SqLite.Connect();
            MessageBox.Show(message);
        }

        private void BtnDevDisconnect_Click(object sender, EventArgs e)
        {
            string message = "Disconnected from Database";
            SqLite.Disconnect();
            MessageBox.Show(message);
        }

        private void BtnDevGenerateTickets_Click(object sender, EventArgs e)
        {
            string message = "Tickets generated";
            SqLite.GenerateTickets();
            MessageBox.Show(message);
        }
    }
}
