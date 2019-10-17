using System;
using System.Windows.Forms;

namespace TicketAppWinForms.Model
{
    class Seat
    {
        public int Id { get; set; }
        public Button SeatButton { get; set; }

        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(int row, int column)
        {
            name = NumberToString(row, true) + column;
        }

        public Seat(int id, ref Button seatButton) {
            Id = id;
            SeatButton = seatButton;
        }



        private String NumberToString(int number, bool isCaps)

        {

            Char c = (Char)((isCaps ? 64 : 96) + number);

            return c.ToString();

        }
    }
}
