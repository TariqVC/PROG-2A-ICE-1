using ShoppingCartApp;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart(10);

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n\t Shopping Cart Menu");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Remove Product");
                Console.WriteLine("3. View Cart Contents");
                Console.WriteLine("4. Exit");
                Console.Write("Enter above number of your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter product name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter product category (0: Electronics, 1: Clothing, 2: Food, 3: Beauty): ");
                        ProductCategory category = (ProductCategory)int.Parse(Console.ReadLine());
                        if (category == ProductCategory.Electronics)
                        {
                            Console.Write("Enter product brand: ");
                            string brand = Console.ReadLine();
                            Console.Write("Enter product model: ");
                            string model = Console.ReadLine();
                            cart.AddProduct(new ElectronicsProduct(name, price, category, brand, model));
                        }
                        else if (category == ProductCategory.Clothing)
                        {
                            Console.Write("Enter product size: ");
                            string size = Console.ReadLine();
                            Console.Write("Enter product color: ");
                            string color = Console.ReadLine();
                            cart.AddProduct(new ClothingProduct(name, price, category, size, color));
                        }
                        else
                        {
                            cart.AddProduct(new Product(name, price, category));
                        }
                        break;
                    case "2":
                        Console.Write("Enter product name to remove: ");
                        string productNameToRemove = Console.ReadLine();
                        foreach (Product product in cart.Products)
                        {
                            if (product != null && product.Name == productNameToRemove)
                            {
                                cart.RemoveProduct(product);
                                break;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n\t Cart Contents");
                        foreach (Product product in cart.Products)
                        {
                            if (product != null)
                            {
                                product.GetInfo();
                            }
                        }
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
