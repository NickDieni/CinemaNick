namespace CinemaDataModels.Models.Entities
{
    public class Seat
    {
        public int SeatId { get; set; }
        public List<Theater> TheaterId { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }

    }
}
