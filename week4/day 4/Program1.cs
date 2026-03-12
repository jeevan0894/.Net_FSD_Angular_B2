using System;

namespace ConsoleApp1.week_4.day_4
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            Calculator Cal=new Calculator();


            Console.Write("ENTER FIRST NUMBER...");
            num1=Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER SECOND NUMBER...");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SUM OF GIVEN NUMBERS ...."+ Cal.Add(num1, num2));

            Console.WriteLine("SUBTRACTION OF GIVEN NUMBERS ...." + Cal.Substraction(num1, num2));
        }
    }
}
