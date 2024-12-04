using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO
{
    public class UserDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string Email { get; set; }
        public int PostalCodeId { get; set; }

    }
}
