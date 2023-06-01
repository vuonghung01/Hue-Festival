using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Data
{
    [Table("ProgramImage")]
    public class ProgramImage
    {
        [Key]
        public int Id { get; set; }
        public int ProgrammId { get; set; }
        public string Image { get; set; }

        [ForeignKey("ProgramId")]
        public Programm Programm { get; set; }
    }
}

