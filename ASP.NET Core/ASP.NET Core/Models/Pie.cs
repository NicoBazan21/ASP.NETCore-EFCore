using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_Core.Models
{
    public class Pie
    {
        //[Key]
        public Int32 PieId { get; set; }
        //[Required]
        //[MaxLength(120)]
        public String Name { get; set; } = String.Empty;
        //[MaxLength(200)]
        public String? ShortDescription { get; set; }
        //[MaxLength(500)]
        public String? LongDescription {  get; set; }
        //[MaxLength(500)]
        public String? AllergyInformation { get; set; }
        public Decimal Price { get; set; }
        public String? ImageUrl { get; set; }
        public String? ImageThumbnailUrl { get; set; }
        public Boolean IsPieOfTheWeek { get; set; }
        public Boolean InStock { get; set; }
        public Int32 CategoryId { get; set; }
        public Category Category { get; set; } = default!;

    }
}
