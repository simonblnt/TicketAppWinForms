using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TicketAppWinForms.Controller;
using TicketAppWinForms.Model;

namespace TicketAppWinForms.View
{
    public partial class StadiumControl : UserControl
    {
        private StadiumController stadiumController;



        public StadiumControl()
        {
            stadiumController = new StadiumController(this);
            InitializeComponent();
            stadiumController.InitializeStadium();
        }
    }
}
