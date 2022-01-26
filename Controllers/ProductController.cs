﻿using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    public class ProductController : Controller
    {
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }

    }
}
