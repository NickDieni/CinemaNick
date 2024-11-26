namespace CinemaDataModels.Models.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public List<User> UserId { get; set; }
        public List<Showtime> ShowtimeId { get; set; }
        public List<Seat> SeatId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

    }
}
