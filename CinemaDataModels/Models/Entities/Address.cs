using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public int BuildingNumber { get; set; }
        public List<PostalCode> PostalCode { get; set; } = new List<PostalCode>();
        public string Country { get; set; }
    }
}
