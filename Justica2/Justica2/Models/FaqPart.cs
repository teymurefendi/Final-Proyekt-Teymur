using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class FaqPart
    {
        [Key]
        public int Id { get; set; }
        public string Question { get; set; }
        public string Text { get; set; }
        [ForeignKey("Faq")]
        public int FaqId { get; set; }
        public Faq Faq { get; set; }
    }
}
