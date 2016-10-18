using Microsoft.AspNetCore.Html;

namespace CoreDemo.Models
{
    public class Product
    {
        private string _name;
        private double _price;
        private string _description;

        public Product(string name, double price, string description)
        {
            _name = name;
            _price = price;
            _description = description;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }

        public HtmlString Description
        {
            get
            {
                return new HtmlString(_description);
            }
        }
    }
}
