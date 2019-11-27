using System;

namespace TicketAppWinForms.Model
{
    class Ticket
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int SeatId { get; set; }
        public int TicketTypeId { get; set; }
        public bool IsSelected { get; set; }
        public DateTime DateSelected { get; set; }
        public bool IsOwned { get; set; }
        public int UserId { get; set; }
        public DateTime DateOwned { get; set; }
    }
}
