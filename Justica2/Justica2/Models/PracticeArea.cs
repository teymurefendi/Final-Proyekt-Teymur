using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class PracticeArea
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(250)]
        public string Img { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [Column(TypeName = "ntext")]
        public string Text1 { get; set; }
        [MaxLength(200)]
        public string Aforizm { get; set; }
        [Column(TypeName = "ntext")]
        public string Text2 { get; set; }
        [Column(TypeName = "ntext")]
        public string Text3 { get; set; }        
        [MaxLength(1000)]
        public string About { get; set; }
        [ForeignKey("Settings")]
        public int SettingId { get; set; }
        public Settings Settings { get; set; }
        public List<PracticeAreaName> PracticeAreaNames { get; set; }

    }
}
