using System;
using System.Security.Cryptography;


namespace ConsoleApp1
{
    internal class problem3
    {
        static void Main(string[] args)
        {
            double salarly;
            double experience;
            String empName;
            double bonusrate;
            Console.Write("ENTER YOUR NAME....");
            empName = Console.ReadLine();

            Console.Write("ENTER YOUR SALARLY...");
            salarly = Convert.ToDouble(Console.ReadLine());

            Console.Write("ENTER YOUR EXPERIENCE...");
            experience = Convert.ToDouble(Console.ReadLine());

            if (experience <= 2)
            {
                bonusrate = 5;
            }
            else if (experience > 2 && experience < 5)
            {
                bonusrate = 10;
            }
            else
            {
                bonusrate = 15;
            }

            double bonus;
            bonus = salarly > 0 ? salarly / 100 * bonusrate : 0;

            double finalsalarly;
            finalsalarly = salarly + bonus;
            Console.WriteLine("Employee " + empName);
            Console.WriteLine("Salarly " + salarly);
            Console.WriteLine("final salarly "+finalsalarly);


        }
    }
}
