using System;

namespace TicketAppWinForms.Model
{
    public class Ticket
    {
        public Ticket(int id, int matchId, int seatId, int ticketTypeId, bool isSelected, bool isOwned, int userId)
        {
            Id = id;
            MatchId = matchId;
            SeatId = seatId;
            TicketTypeId = ticketTypeId;
            IsSelected = isSelected;
            IsOwned = isOwned;
            UserId = userId;
        }

        public Ticket()
        {

        }

        public int Id { get; set; }
        public int MatchId { get; set; }
        public int SeatId { get; set; }
        public int TicketTypeId { get; set; }
        public bool IsSelected { get; set; }
        public bool IsOwned { get; set; }
        public int UserId { get; set; }
    }
}
