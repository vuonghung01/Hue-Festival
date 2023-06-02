using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Models
{
    [Table("TicketType")]
    public class TicketType
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
