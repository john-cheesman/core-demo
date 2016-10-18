using Microsoft.AspNetCore.Html;
using CoreDemo.Models;

namespace CoreDemo.ViewModels
{
    public class ProductViewModel
    {
        private Product _product;

        public ProductViewModel(Product product)
        {
            _product = product;
        }

        public string Name
        {
            get
            {
                return _product.Name;
            }
        }

        public double Price
        {
            get
            {
                return _product.Price;
            }
        }

        public HtmlString Description
        {
            get
            {
                return _product.Description;
            }
        }
    }
}