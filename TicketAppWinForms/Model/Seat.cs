using System;

namespace TicketAppWinForms.Model
{
    class Seat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string GetName()
        {
            return Name;
        }

        public void SetName(int row, int column)
        {
            Name = NumberToAlphabet(row, true) + column;
        }

        public Seat(int id) {
            Id = id;
        }

        public Seat(int id, string name) {
            Id = id;
            this.Name = name;
        }

        private String NumberToAlphabet(int number, bool isCaps)
        {
            Char c = (Char)((isCaps ? 64 : 96) + number);
            return c.ToString();
        }
    }
}
