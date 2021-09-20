using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class WeDidPart
    {
        [Key]
        public int Id { get; set; }        
        public int Number { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [ForeignKey("WhatWeDid")]
        public int WhatDidId { get; set; }
        public WhatWeDid WhatWeDid { get; set; }
    }
}
