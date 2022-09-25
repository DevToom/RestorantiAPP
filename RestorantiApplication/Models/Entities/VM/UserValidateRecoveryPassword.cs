using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities.VM
{
    public class UserValidateRecoveryPassword
    {
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string Password { get;set; }
        public string ConfirmPassword { get; set; }

    }
}
