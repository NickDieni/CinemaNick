namespace CinemaDataModels.Models.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public PostalCode PostalCode { get; set; }
        public int PostalCodeId { get; set; }
    }
}
