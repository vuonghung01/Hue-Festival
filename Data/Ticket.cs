using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Data
{
    [Table("Ticket")]
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public int TicketTypeId { get; set; }
        [ForeignKey("TicketTypeId")]
        public TicketType TicketType { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public bool Status { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
