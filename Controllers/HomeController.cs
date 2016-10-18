using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreDemo.Models;
using CoreDemo.ViewModels;

namespace CoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product("Blueberry Muffin", 3.50, "<p>Fresh baked blueberry muffin</p>"),
                new Product("Chocolate Brownie", 4.00, "<p>Superb, rich chocolate brownie</p>")
            };

            return View(new ProductListViewModel(products));
        }
    }
}
