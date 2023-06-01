using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Data
{
    [Table("LocationLiked")]
    public class LocationLiked
    {
        [Key]
        public int Id { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
