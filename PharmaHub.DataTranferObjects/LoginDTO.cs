using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaHub.DataTranferObjects
{
    public class LoginDTO
    {
        public int LoginId { get; set; }

        public string EmailId { get; set; } = null!;

        public string UserPassword { get; set; } = null!;

        public int? RoleId { get; set; }
    }

    public class AddLoginDto
    {
        public string EmailId { get; set; } = null!;

        public string UserPassword { get; set; } = null!;

        public int? RoleId { get; set; }
    }

    public class GetLoginDto
    {
        public int LoginId { get; set; }
        public string EmailId { get; set; } = null!;
        public string Role { get; set; } = null!;
    }

    public class SaveLoginDto
    {
        public int LoginId { get; set; }
        public string EmailId { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string token { get; set; } = null!;  
    }
}
