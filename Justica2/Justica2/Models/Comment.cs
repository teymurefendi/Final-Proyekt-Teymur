using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Justica2.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("CustomUser")]
        public string UserId { get; set; }
        public CustomUser CustomUser { get; set; }
        [ForeignKey("News")]
        public int NewsId { get; set; }
        public News News { get; set; }
        public int? CommentId { get; set; }
        [ForeignKey("CommentId")]
        public Comment ParentComment { get; set; }
        [MaxLength(3000)]
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
