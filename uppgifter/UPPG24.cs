using System;

namespace UPPG21ellernångonannan
{
    internal class Program
    {
        class Product
        {
            // Private fields to store product with name, price, and quantity
            private string name;
            private double price;
            private int stock;

            // Constructor
            public Product(string name, double price, int stock)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name"; // Assign the product name
                SetPrice(price); // Validate and set the product price
                SetStock(stock); // Validate and set the stock quantity
            }

            // Method to set the name of the product
            public void SetName(string name)
            {
                // Validate the name and assign or set a default value
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid Name";
            }

            // Method to get the name of the product
            public string GetName()
            {
                // Return the name of the product
                return name;
            }

            // Method to set price of the product
            public void SetPrice(double price)
            {
                // Assign a positive price or default to 0 if input is invalid
                this.price = price > 0 ? price : 0;
            }

            // Method to get the price of the product
            public double GetPrice()
            {
                // Return the price of the product
                return price;
            }

            // Method to set the stock quantity
            public void SetStock(int stock)
            {
                // Assign a non-negative stock or default to 0 if input is invalid
                this.stock = stock >= 0 ? stock : 0;
            }

            // Method to get the stock quantity
            public int GetStock()
            {
                // Return the stock quantity of the product
                return stock;
            }

            // Method to return the details of the product
            public string ReturnDetails()
            {
                // Return the details about the product "Name, Price, Stock"
                return $"Name: {name}\nPrice: {price:C}\nStock: {stock}";
            }
        }

        static void Main(string[] args)
        {
            // Create an instance of the Product class
            Product product = new Product("Phone", 599, 5);

            // Print the details of the product
            Console.WriteLine(product.ReturnDetails());

            // Update the product details
            product.SetName("Laptop");
            product.SetPrice(999.99);
            product.SetStock(10);

            // Print the updated details of the product
            Console.WriteLine(product.ReturnDetails());

            Console.ReadLine(); // Wait for user input before closing the console
        }
    }
}
