using CinemaDataModels.Models.Entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO
{
    public class GenreDto
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public List<Movie> Movies { get; set; } = new List<Movie>();
    }
}
