namespace CinemaDataModels.Models.Entities
{
    public class Showtime
    {
        public int ShowtimeId { get; set; }
        public Movie Movie { get; set; } = new Movie();
        public Theater Theater { get; set; } = new Theater();
        public DateTime ShowtimeStart { get; set; }

    }
}
