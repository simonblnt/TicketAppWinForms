using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketAppWinForms.Model
{
    class TicketType
    {
        public TicketType(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
