namespace CinemaDataModels.Models.Entities
{
    public class Theater
    {
        public int TheaterId { get; set; }
        public string TheaterName { get; set; }
        public int Capacity { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
    }
}
