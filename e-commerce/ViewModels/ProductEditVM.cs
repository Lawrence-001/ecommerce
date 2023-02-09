using e_commerce.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace e_commerce.ViewModels
{
    public class ProductEditVM
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Category")]
        public ProductCategory ProductCategory { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public double Cost { get; set; }
    }
}
