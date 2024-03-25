using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class Product
    {
        private String name;
        private double price;
        private ProductCategory category;

        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }
        public string Name
        {
            get { return name; }
        }

        public double Price
        {
            get { return price; }
        }

        public ProductCategory Category
        {
            get { return category; }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Name: {name}, Price: {price}, Category: {category}");
        }
    }
}
