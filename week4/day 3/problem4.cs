using System;

namespace ConsoleApp1
{
    internal class problem4
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            int evenCount=0;
            int oddCount=0;
            Console.Write("ENTER A NUMBER :");
            num= Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i%2==0)
                {
                    evenCount++;
                    
                }
                else
                {
                    oddCount++;
                }
                sum = sum + i;

            }
            Console.WriteLine("NUMBER OF EVEN " +evenCount);
            Console.WriteLine("NUMBER OF ODD NUMBERS "+oddCount);
            Console.WriteLine("SUM OF N NUMBERS "+sum);
           

        }
    }
}
