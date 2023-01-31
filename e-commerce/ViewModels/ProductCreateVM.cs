﻿using e_commerce.Models;
using System.ComponentModel.DataAnnotations;

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
        public decimal Cost { get; set; }
    }
}