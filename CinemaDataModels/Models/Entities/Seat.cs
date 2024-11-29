namespace CinemaDataModels.Models.Entities
{
    public class Seat
    {
        public int SeatId { get; set; }
        public Theater Theater { get; set; }
        public int TheaterId { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }

    }
}
