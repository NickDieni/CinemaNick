using CinemaDataModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDataModels.Models.DTO
{
    public class UpdateUserRequestDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;   // NULL! ER "null forgiving operator".
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public PostalCode PostalCodes { get; set; } = new PostalCode();
    }
}
