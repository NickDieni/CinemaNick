namespace CinemaDataModels.Models.Entities
{
    public class Showtime
    {
        public int ShowtimeId { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public Theater Theater { get; set; }
        public int TheaterId { get; set; }
        public DateTime ShowtimeStart { get; set; }

    }
}
