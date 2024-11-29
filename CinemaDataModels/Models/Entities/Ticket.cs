namespace CinemaDataModels.Models.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public User User { get; set; } = new User();
        public Showtime ShowtimeId { get; set; } = new Showtime();
        public Seat SeatId { get; set; } = new Seat();
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

    }
}
