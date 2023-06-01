using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Data
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public List<LocationLiked> LocationLiked { get; set; }
        public List<NewsLiked> NewsLiked { get; set; }
        public List<EventLiked> EventLiked { get; set; }
    }
}
