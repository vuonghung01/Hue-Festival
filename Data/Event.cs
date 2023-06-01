using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Data
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public int ProgramId { get; set; }
        [ForeignKey("ProgramId")]
        public Programm Programm { get; set; }

        public DateTime Time { get; set; }
        public DateTime fdate { get; set; }
        public DateTime tdate { get; set; }

        public int LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }
    }
}
