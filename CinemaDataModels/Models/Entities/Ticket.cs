namespace CinemaDataModels.Models.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Showtime Showtime { get; set; }
        public int ShowtimeId { get; set; }
        public Seat Seat { get; set; }
        public int SeatId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

    }
}
