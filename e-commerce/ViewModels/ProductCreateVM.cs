using e_commerce.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e_commerce.ViewModels
{
    public class ProductCreateVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name ="Category")]
        public ProductCategory  ProductCategory { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        [Column (TypeName ="decimal(18, 2")]
        public decimal Cost { get; set; }
    }
}
