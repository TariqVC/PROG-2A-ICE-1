using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ClothingProduct : Product
    {
        // Fields
        private readonly string size;
        private readonly string color;

        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
        : base(name, price, category)
        {
            this.size = size;
            this.color = color;
        }
        public string Size
        {
            get { return size; }
        }

        public string Color
        {
            get { return color; }
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}, Size: {size}, Color: {color}");
        }
    }
}