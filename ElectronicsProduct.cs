using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ElectronicsProduct : Product
    {
        // Fields
        private readonly string brand;
        private readonly string model;

        // Properties
       

        // Constructor
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        public string Brand
        {
            get { return brand; }
        }

        public string Model
        {
            get { return model; }
        }

        // Method to override GetInfo() for electronics product
        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}, Category: {Category}, Brand: {brand}, Model: {model}");
        }
    }
}
