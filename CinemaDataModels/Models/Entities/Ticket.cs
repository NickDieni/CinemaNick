namespace CinemaDataModels.Models.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public User User { get; set; }
        public Showtime ShowtimeId { get; set; }
        public Seat SeatId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

    }
}
