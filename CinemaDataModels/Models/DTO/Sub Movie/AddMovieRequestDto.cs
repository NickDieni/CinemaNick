using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO
{
    public class AddMovieRequestDto
    {
        public string Title { get; set; }
        public int DurationMinutes { get; set; }
        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<int> GenreIds { get; set; } = new List<int>();
    }

}
