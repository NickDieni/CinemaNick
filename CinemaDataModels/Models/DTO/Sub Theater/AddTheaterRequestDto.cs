using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO.Sub_Theater
{
    public class AddTheaterRequestDto
    {
        public string TheaterName { get; set; }
        public int Capacity { get; set; }
        public int AddressId { get; set; }
    }
}
