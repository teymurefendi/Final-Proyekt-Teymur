using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class Subscribe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100), Required]
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
