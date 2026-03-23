using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6handson.day1
{
    internal class problem1
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Application started...");

            // Simulate multiple log events running asynchronously
            Task log1 = WriteLogAsync("User logged in");
            Task log2 = WriteLogAsync("File uploaded");
            Task log3 = WriteLogAsync("Data processed");
            Task log4 = WriteLogAsync("User logged out");

            Console.WriteLine("Main thread continues working...");

            // Simulate other work happening while logs are written
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Main thread working... {i}");
                await Task.Delay(500);
            }

            // Wait for all log operations to complete
            await Task.WhenAll(log1, log2, log3, log4);

            Console.WriteLine("All logs completed.");
        }

        static async Task WriteLogAsync(string message)
        {
            Console.WriteLine($"Starting log: {message}");

            // Simulate file writing delay
            await Task.Delay(2000);

            Console.WriteLine($"Finished log: {message}");
        }
    }
}

