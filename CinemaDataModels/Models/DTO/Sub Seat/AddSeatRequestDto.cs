using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO.Sub_Seat
{
    public class AddSeatRequestDto
    {
        public int TheaterId { get; set; }
        public int RowNumber { get; set; }
        public int SeatNumber { get; set; }
    }
}
