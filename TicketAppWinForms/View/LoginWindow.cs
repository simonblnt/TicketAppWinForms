using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketAppWinForms.DataAccess;
using TicketAppWinForms.Model;

namespace TicketAppWinForms.View
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void BtnLoadDefaultData_Click(object sender, EventArgs e)
        {
            
        }

        private void LblLoginUsername_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = tbLoginUsername.Text;
            string password = tbLoginPassword.Text;

            if (SqLite.IsLoginSuccessful(username, password))
            {
                User user = SqLite.QueryLoggedInUser(username);
                if (user.AccountTypeId == 3)
                {
                    var developerWindow = new DeveloperWindow();
                    this.Close();
                    developerWindow.Show();
                }
                else
                {
                    MatchSelectWindow matchSelectWindow = new MatchSelectWindow(user);
                    this.Close();
                    matchSelectWindow.Show();
                }
                
            }
            else {
                tbLoginUsername.Clear();
                tbLoginPassword.Clear();
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
