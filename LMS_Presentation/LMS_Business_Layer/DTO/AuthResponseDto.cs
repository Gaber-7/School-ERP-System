using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.DTO
{
    public class AuthResponseDto
    {
        public string Token { get; set; }
        public DateTime ExpireAt { get; set; }

        public string UserName { get; set; }
        public string Role { get; set; }

        public List<string> Permissions { get; set; } = new();
    }
}
