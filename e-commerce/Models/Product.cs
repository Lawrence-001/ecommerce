using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace e_commerce.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Category")]
        public ProductCategory? ProductCategory { get; set; }
        public string ImgUrl { get; set; }
        [Required]
        public decimal Cost { get; set; }

    }
}
