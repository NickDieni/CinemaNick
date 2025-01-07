using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO.Sub_Ticket
{
    public class AddTicketRequestDto
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Showtime Showtime { get; set; }
        public int ShowtimeId { get; set; }
        public Seat Seat { get; set; }
        public int SeatId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
    }
}
