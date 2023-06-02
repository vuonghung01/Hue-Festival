using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;
        public string? VerificationToken { get; set; }
        public DateTime? VerifiedAt { get; set; }

        public List<LocationLiked> LocationLiked { get; set; }
        public List<NewsLiked> NewsLiked { get; set; }
        public List<EventLiked> EventLiked { get; set; }
    }
}
