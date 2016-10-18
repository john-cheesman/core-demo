using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDemo.Models;
using CoreDemo.ViewModels;

namespace CoreDemo.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Blueberry Muffin", 3.50, "<p>Fresh baked blueberry muffin</p>"),
                new Product("Chocolate Brownie", 4.00, "<p>Superbly rich chocolate brownie</p>"),
                new Product("Lemon Tart", 3.50, "<p>Our classic, zingy lemon tart</p>")
            };

            return View(new ProductListViewModel(products));
        }
    }
}
