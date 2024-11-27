using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO
{
    public class MovieDto
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public int DurationMinutes { get; set; }
        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
