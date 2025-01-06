namespace CinemaDataModels.Models.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string? Title { get; set; }
        public int DurationMinutes { get; set; }
        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
    }
}
