using System.Collections.Generic;
using Microsoft.AspNetCore.Html;
using CoreDemo.Models;

namespace CoreDemo.ViewModels
{
    public class ProductListViewModel
    {
        private List<Product> _products;

        public ProductListViewModel(List<Product> products)
        {
            _products = products;
        }

        public List<ProductViewModel> Products
        {
            get
            {
                List<ProductViewModel> viewModels = new List<ProductViewModel>();

                foreach (Product product in _products)
                {
                    viewModels.Add(new ProductViewModel(product));
                }

                return viewModels;
            }
        }
    }
}