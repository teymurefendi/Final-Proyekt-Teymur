using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Icon1 { get; set; }
        [NotMapped]
        public IFormFile ImageFile1 { get; set; }
        [MaxLength(250)]
        public string Icon2 { get; set; }
        [NotMapped]
        public IFormFile ImageFile2 { get; set; }
        [MaxLength(30)]
        public string Phone1 { get; set; }
        [MaxLength(30)]
        public string Phone2 { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Link { get; set; }
        [MaxLength(100)]
        public string Brochure { get; set; }

        public List<SettingSocial> SettingSocials { get; set; }
        public List<PracticeArea> PracticeAreas { get; set; }
    }
}
