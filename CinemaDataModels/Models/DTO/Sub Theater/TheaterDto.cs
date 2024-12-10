using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO.Sub_Theater
{
    public class TheaterDto
    {
        public int TheaterId { get; set; }
        public string TheaterName { get; set; }
        public int Capacity { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
    }
}
