namespace CinemaDataModels.Models.Entities
{
    public class Theater
    {
        public int TheaterId { get; set; }
        public string TheaterName { get; set; }
        public List<PostalCode> PostalCodeId { get; set; } = new List<PostalCode>();
        public int Capacity { get; set; }
    }
}
