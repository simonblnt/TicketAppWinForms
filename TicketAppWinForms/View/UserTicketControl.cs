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

namespace TicketAppWinForms.View
{
    public partial class UserTicketControl : UserControl
    {
        private UserTicketControlController userTicketController;

        public UserTicketControl()
        {
            userTicketController = new UserTicketControlController(this);
            InitializeComponent();
        }
    }
}
