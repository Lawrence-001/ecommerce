﻿using e_commerce.Data;
using e_commerce.Models;
using e_commerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepo _productRepo;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, IProductRepo productRepo, AppDbContext context)
        {
            _logger = logger;
            _productRepo = productRepo;
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _productRepo.GetProducts();
            return View(model);
        }
        [HttpGet]
        public IActionResult Index( string searchString)
        {
            var productQuery = from m in _context.Products select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                productQuery = productQuery.Where(s => s.Name.Contains(searchString) || s.Description.Contains(searchString));
            }
            return View(productQuery);
            //var model = _productRepo.GetProducts();
            //return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            ProductCreateVM productCreateVM = new ProductCreateVM();
            if (ModelState.IsValid)
            {
                _productRepo.AddProduct(newProduct);
                return RedirectToAction("index");
            }
            return View(productCreateVM);
        }
        public IActionResult Details(int id)
        {
            var prod = _productRepo.GetProductById(id);
            if (prod != null)
            {
                return View(prod);
            }
            return View("NotFound");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productRepo.GetProductById(id);
            if (product != null)
            {
                ProductEditVM prod = new ProductEditVM()
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Description = product.Description,
                    ProductCategory = (ProductCategory)product.ProductCategory,
                    ImgUrl = product.ImgUrl,
                    Cost = product.Cost
                };
                return View(prod);
            }
            return View("NotFound");
        }
        [HttpPost]
        public IActionResult Edit(ProductEditVM model)
        {
            if (ModelState.IsValid)
            {
                var prod = _productRepo.GetProductById(model.ProductId);
                prod.Name = model.Name;
                prod.Description = model.Description;
                prod.ProductCategory = model.ProductCategory;
                prod.ImgUrl = model.ImgUrl;
                prod.Cost = model.Cost;
                _productRepo.UpdateProduct(prod);
                return RedirectToAction("index");

            }
            return View(model);
        }
        public IActionResult Delete(int id)
        {
            var prod = _productRepo.GetProductById(id);
            if (prod != null)
            {
                _productRepo.DeleteProduct(id);
                return RedirectToAction("index");
            }
            return View("NotFound");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
