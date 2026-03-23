using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6handson.day1
{
    internal class problem2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retail Discount Calculator");

            // Input
            Console.Write("Enter Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Discount Percentage: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            // Calculation
            double finalPrice = CalculateFinalPrice(price, discount);

            // Output
            Console.WriteLine("\nProduct: " + productName);
            Console.WriteLine("Original Price: " + price);
            Console.WriteLine("Discount: " + discount + "%");
            Console.WriteLine("Final Price: " + finalPrice);

            Console.ReadLine();
        }

        static double CalculateFinalPrice(double price, double discount)
        {
            // Place breakpoint here
            double discountAmount = price * discount / 100;

            // Step Over this line
            double finalPrice = price - discountAmount;

            return finalPrice;
        }
    }



}

