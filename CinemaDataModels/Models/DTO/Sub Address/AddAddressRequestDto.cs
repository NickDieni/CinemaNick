using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO.Sub_Address
{
    public class AddAddressRequestDto
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int Building { get; set; }
        public int Floor { get; set; }
        public string Direction { get; set; }
        public int PostalCodeId { get; set; }
    }
}
