namespace CinemaDataModels.Models.Entities
{
    public class Seat
    {
        public int SeatId { get; set; }
        public Theater TheaterId { get; set; } = new Theater();
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }

    }
}
