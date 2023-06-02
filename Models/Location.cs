using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hue_Festival.Models
{
    [Table("Location")]
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string? Content { get; set; }
        public string ImagePath { get; set; }
        public string Longtitude { get; set; }
        public string Latitude { get; set; }


        //public int LocationTypeId { get; set; }
        //[ForeignKey("LocationTypeId")]
        //public LocationType LocationType { get; set; }
    }
}
