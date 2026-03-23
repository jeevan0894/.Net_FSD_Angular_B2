using System;
using System.Diagnostics;
using System.IO;

namespace week6handson.day1
{
    internal class problem5
    {
        static void Main(string[] args)
        {
            // Configure trace listener to write logs to file
            Trace.Listeners.Add(new TextWriterTraceListener("OrderLog.txt"));
            Trace.AutoFlush = true;

            Trace.TraceInformation("Order processing started.");

            try
            {
                ValidateOrder();
                ProcessPayment();
                UpdateInventory();
                GenerateInvoice();

                Trace.TraceInformation("Order processing completed successfully.");
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Error occurred: " + ex.Message);
            }

            Console.WriteLine("Order processing finished. Check OrderLog.txt for trace logs.");
            Console.ReadLine();
        }

        static void ValidateOrder()
        {
            Trace.WriteLine("Step 1: Validating order...");
            // Simulate processing
            System.Threading.Thread.Sleep(1000);

            Trace.TraceInformation("Order validation successful.");
        }

        static void ProcessPayment()
        {
            Trace.WriteLine("Step 2: Processing payment...");
            System.Threading.Thread.Sleep(1500);

            Trace.TraceInformation("Payment processed successfully.");
        }

        static void UpdateInventory()
        {
            Trace.WriteLine("Step 3: Updating inventory...");
            System.Threading.Thread.Sleep(1200);

            // Example issue simulation (optional)
            // throw new Exception("Inventory update failed");

            Trace.TraceInformation("Inventory updated successfully.");
        }

        static void GenerateInvoice()
        {
            Trace.WriteLine("Step 4: Generating invoice...");
            System.Threading.Thread.Sleep(1000);

            Trace.TraceInformation("Invoice generated successfully.");
        }
    }


}

