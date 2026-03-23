using System;
using System.Threading;
using System.Threading.Tasks;

namespace week6handson.day1
{
    internal class problem3
    {

        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting report generation...\n");

            // Running tasks concurrently
            Task salesTask = Task.Run(() => GenerateSalesReport());
            Task inventoryTask = Task.Run(() => GenerateInventoryReport());
            Task customerTask = Task.Run(() => GenerateCustomerReport());

            Console.WriteLine("All reports are processing concurrently...\n");

            // Wait for all tasks to complete
            await Task.WhenAll(salesTask, inventoryTask, customerTask);

            Console.WriteLine("\nAll reports generated successfully!");
            Console.ReadLine();
        }

        static async Task GenerateSalesReport()
        {
            Console.WriteLine("Sales Report started...");
            await Task.Delay(3000); // simulate processing time
            Console.WriteLine("Sales Report completed.");
        }

        static async Task GenerateInventoryReport()
        {
            Console.WriteLine("Inventory Report started...");
            await Task.Delay(2000);
            Console.WriteLine("Inventory Report completed.");
        }

        static async Task GenerateCustomerReport()
        {
            Console.WriteLine("Customer Report started...");
            await Task.Delay(4000);
            Console.WriteLine("Customer Report completed.");
        }
    }


}

