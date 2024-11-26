namespace CinemaDataModels.Models.Entities
{
    public class Showtime
    {
        public int ShowtimeId { get; set; }
        public List<Movie> MovieId { get; set; } = new List<Movie>();
        public List<Theater> TheaterId { get; set; } = new List<Theater>();
        public DateTime ShowtimeStart { get; set; }

    }
}
