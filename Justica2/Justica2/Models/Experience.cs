using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class Experience
    {
        [Key]
        public int Id { get; set; }        
        public int Year { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
