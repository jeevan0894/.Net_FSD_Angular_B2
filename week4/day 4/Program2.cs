using System;

namespace ConsoleApp1.week_4.day_4
{
    internal class Program2
    {
        public static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.Write("ENTER FIRST MARKS.....");
            num1 =Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER SECOND MARKS.....");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ENTER THIRD MARKS.....");
            num3 = Convert.ToInt32(Console.ReadLine());

            char grade;
            Student std= new Student();
            int AvgMarks=std.CalculateAverage(num1,num2,num3);
            if (AvgMarks>=80)
            {
                grade = 'A';                
            }
            else if (AvgMarks>=60 && AvgMarks<80)
            {

                grade = 'B';
            }
            else if (AvgMarks >= 40 && AvgMarks < 60)
            {

                grade = 'C';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine("AVERAGE MARKS....."+AvgMarks);
            Console.WriteLine("GRADE..."+grade);



        }
    }
}
