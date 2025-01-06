namespace CinemaDataModels.Models.Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        
        public List<Movie> Movies { get; set; } = new List<Movie>();

    }
}
