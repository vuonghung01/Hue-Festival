using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Data
{
    [Table("Program")]
    public class Programm
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int TypeInOff { get; set; }
        public double Price { get; set; }
        public int Type_Program { get; set; }
        public int Arrange { get; set; }

        public List<Event> Event_list { get; set; }

        public List<ProgramImage> PathImage_list { get; set; }

    }
}
