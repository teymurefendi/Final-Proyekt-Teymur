using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class PracticeAreaName
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [ForeignKey("practiceArea")]
        public int PracticeAreaId { get; set; }
        public PracticeArea practiceArea { get; set; }
    }
}
