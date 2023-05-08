using System;
using System.Collections.Generic;

namespace Exam

{
    class Program
    {
        static List<Product> products = new List<Product>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("PRODUCT MANAGEMENT");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display Products");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Exit");

                Console.Write("Select an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        DisplayProducts();
                        break;
                    case "3":
                        DeleteProduct();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("ADD PRODUCT");

            Console.Write("Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Product Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Product product = new Product(id, name, price);
            products.Add(product);

            Console.WriteLine("Product added successfully.");
        }

        static void DisplayProducts()
        {
            Console.WriteLine("PRODUCT LIST");

            Console.WriteLine("{0,-10} {1,-20} {2,-10}", "ID", "Name", "Price");

            foreach (Product product in products)
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-10}", product.Id, product.Name, product.Price);
            }
        }

        static void DeleteProduct()
        {
            Console.WriteLine("DELETE PRODUCT");

            Console.Write("Product ID: ");
            int id = int.Parse(Console.ReadLine());

            int index = products.FindIndex(product => product.Id == id);

            if (index == -1)
            {
                Console.WriteLine("Product not found.");
            }
            else
            {
                products.RemoveAt(index);
                Console.WriteLine("Product deleted successfully.");
            }
        }
    }
}