using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Img { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Column(TypeName = "ntext")]
        public string Text1 { get; set; }
        [Column(TypeName = "ntext")]
        public string Text2 { get; set; }
        [Column(TypeName = "ntext")]
        public string Text3 { get; set; }
        [MaxLength(300)]
        public string Aforizm { get; set; }
        public DateTime CreatedDAte { get; set; }
        [MaxLength(500)]
        public string About { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }

        public List<NewsToTag> NewsToTags { get; set; }
        public List<Comment> Comments { get; set; }
        public List<NewsName> NewsNames { get; set; }
    }
}
