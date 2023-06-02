using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Models
{
    [Table("NewsLiked")]
    public class NewsLiked
    {
        [Key]
        public int Id { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
