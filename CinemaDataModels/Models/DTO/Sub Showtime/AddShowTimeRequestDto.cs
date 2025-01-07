using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO.Sub_Showtime
{
    public class AddShowTimeRequestDto
    {
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public Theater Theater { get; set; }
        public int TheaterId { get; set; }
        public DateTime ShowtimeStart { get; set; }
    }
}
