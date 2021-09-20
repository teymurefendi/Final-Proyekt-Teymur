using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class SettingSocial
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Icon { get; set; }
        [MaxLength(100)]
        public string Link { get; set; }
        [ForeignKey("Settings")]
        public int SettingId { get; set; }
        public Settings Settings { get; set; }

    }
}
