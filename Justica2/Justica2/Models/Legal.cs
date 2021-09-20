using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class Legal
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Text { get; set; }
        [MaxLength(250)]
        public string Img1 { get; set; }
        [NotMapped]
        public IFormFile ImageFile1 { get; set; }
        [MaxLength(250)]
        public string Img2 { get; set; }
        [NotMapped]
        public IFormFile ImageFile2 { get; set; }
        public int Number { get; set; }
    }
}
