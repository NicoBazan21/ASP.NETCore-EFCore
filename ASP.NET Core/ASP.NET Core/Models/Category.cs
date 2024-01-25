using System.ComponentModel.DataAnnotations;

namespace ASP.NET_Core.Models
{
    public class Category
    {
        //[Key]
        public Int32 CategoryId { get; set; }
        //[Required]
        //[MaxLength(100)]
        public String CategoryName { get; set; } = String.Empty;
        public String? Description { get; set; }
        public List<Pie>? Pies { get; set; }
    }
}
