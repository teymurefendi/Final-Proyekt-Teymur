using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class TeamSocial
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Icon { get; set; }
        public List<TeamToSocial> TeamToSocials { get; set; }
    }
}
