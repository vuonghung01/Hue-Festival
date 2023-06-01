using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Data
{
    [Table("LocationType")]
    public class LocationType
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
