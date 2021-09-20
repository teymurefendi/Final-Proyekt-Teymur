using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class CustomUser: IdentityUser
    {
        [MaxLength(30), Required]
        public string Name { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
