using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class Faq
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Topic { get; set; }
        public List<FaqPart> FaqParts { get; set; }
    }
}
