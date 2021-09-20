using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "ntext"),MaxLength(4000)]
        public string About { get; set; }
        [MaxLength(250)]
        public string Img { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public List<TeamToSocial> TeamToSocials { get; set; }
    }
}
