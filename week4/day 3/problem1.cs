using System;


namespace ConsoleApp1
{
    internal class problem1
    {
        static void Main(string[] args)
        {
            String stdName;
            int marks;
            Console.Write("ENTER STUDENT NAME ....:");
            stdName = Console.ReadLine();
            Console.Write("ENTER STUDENT MARKS......");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("INVALID MARKS....");

            }
            else
            {
                String grade;

                if (marks >= 90)
                {
                    grade = "A";
                }
                else if (marks >= 75 && marks < 90)
                {
                    grade = "B";
                }
                else if (marks >= 60 && marks < 75)
                {
                    grade = "C";
                }
                else if (marks >= 45 && marks < 60)
                {
                    grade = "D";
                }
                else if (marks >= 35 && marks < 45)
                {
                    grade = "E";
                }
                else
                {
                    grade = "FAIL";
                }
                Console.WriteLine("STUDENAT NAME :" + stdName);
                Console.WriteLine("STUDENT MARKS :" + marks);
                Console.WriteLine("STUDENT GRADE :" + grade);
            }
        }
    }
}
