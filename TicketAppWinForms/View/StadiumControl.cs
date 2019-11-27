using System.Windows.Forms;
using TicketAppWinForms.Controller;
using TicketAppWinForms.Model;

namespace TicketAppWinForms.View
{
    public partial class StadiumControl : UserControl
    {
        private StadiumControlController stadiumController;
        public StadiumControl(Match match)
        {
            System.Console.WriteLine();
            stadiumController = new StadiumControlController(this, match);
            InitializeComponent();
        }
    }
}
