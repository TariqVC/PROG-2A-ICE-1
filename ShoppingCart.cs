using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    public class ShoppingCart
    {
        // Fields
        private Product[] products;
        private int itemCount;

        // Properties
        public Product[] Products
        {
            get { return products; }
        }

        public int ItemCount
        {
            get { return itemCount; }
        }

        // Constructor
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity];
            itemCount = 0;
        }

        // Method to add a product to the shopping cart
        public void AddProduct(Product product)
        {
            if (itemCount < products.Length)
            {
                products[itemCount] = product;
                itemCount++;
            }
            else
            {
                Console.WriteLine("Shopping cart is full.");
            }
        }

        // Method to remove a product from the shopping cart
        public void RemoveProduct(Product product)
        {
            int index = Array.IndexOf(products, product);
            if (index != -1)
            {
                for (int i = index; i < itemCount - 1; i++)
                {
                    products[i] = products[i + 1];
                }
                itemCount--;
                products[itemCount] = null; 
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }

}
