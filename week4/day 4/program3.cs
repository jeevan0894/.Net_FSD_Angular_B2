using System;


namespace ConsoleApp1.week_4.day_4
{
    internal class program3
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("ENTER FIRST MARKS.....");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER SECOND MARKS.....");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER THIRD MARKS.....");
            num3 = Convert.ToInt32(Console.ReadLine());

            Student std1=new Student();
            std1.CalculateResult(num1, num2, num3, out int total, out double Avg);
            String result;
            if (Avg>=40)
            {
                result = "PASS";
            }
            else
            {
                result = "FAIL";
            }

            Console.WriteLine("TOTAL MARKS....."+total);
            Console.WriteLine("AVERAGE MARKS....." + Avg);
            Console.WriteLine(" STUDENT IS....." + result+"  IN THE EXAM");
        }
    }
}
