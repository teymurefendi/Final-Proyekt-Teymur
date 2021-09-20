using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.ViewModels
{
    public class VmRegister
    {
        [MaxLength(50), Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MaxLength(50), Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [MaxLength(50), Required]
        [DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
