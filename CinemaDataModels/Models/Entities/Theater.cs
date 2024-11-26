namespace CinemaDataModels.Models.Entities
{
    public class Theater
    {
        public int TheaterId { get; set; }
        public string TheaterName { get; set; }
        public List<PostalCode> PostalCodeId { get; set; }
        public int Capacity { get; set; }
    }
}
