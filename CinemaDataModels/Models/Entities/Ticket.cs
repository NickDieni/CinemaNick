namespace CinemaDataModels.Models.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public List<User> UserId { get; set; } = new List<User>();
        public List<Showtime> ShowtimeId { get; set; } = new List<Showtime>();
        public List<Seat> SeatId { get; set; } = new List<Seat>();
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

    }
}
