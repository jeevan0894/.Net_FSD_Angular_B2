using System;

namespace ConsoleApp1.week_4.day_4
{
    internal class Program4
    {
        public static void Main(string[] args)
        {
            Calculator cal1 = new Calculator();
            Console.WriteLine("TOTAL AMOUNT " + cal1.CalculateFinalAmount(200, 2));

            Console.WriteLine("TOTAL AMOUNT "+cal1.CalculateFinalAmount(200, 2, 10, 100));

            Console.WriteLine("TOTAL AMOUNT " + cal1.CalculateFinalAmount(200, 2,5));
        }
    }
}
