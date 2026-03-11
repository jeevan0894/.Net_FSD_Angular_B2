using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Problem2
    {
        static void Main(string[] args)
        {
            double result;
            int first_Number;
            Console.Write("ENTER FIRST NUMBER...");
            first_Number =Convert.ToInt32( Console.ReadLine());



            double secondNumber;
            Console.WriteLine("Enter SECOND NUMBER....");
            secondNumber = Convert.ToDouble( Console.ReadLine());

            char op;
            Console.Write("ENTER THE OPERATION YOU WANF ('+','-','*','/'):");
            op=Convert.ToChar( Console.ReadLine());

            if (first_Number<=0 || secondNumber<=0)
            {
                Console.WriteLine("BOTH THE NUMBERS ARE GRATE THAN '0' ");
            }
            else
            {
                switch (op)
                {
                    case '+':
                        result = first_Number + secondNumber;
                        Console.WriteLine("YOUR RESULT IS " + result);
                        break;
                    case '-':
                        result = first_Number - secondNumber;
                        Console.WriteLine("YOUR RESULT IS " + result);
                        break;
                    case '*':
                        result = first_Number * secondNumber;
                        Console.WriteLine("YOUR RESULT IS " + result);
                        break;
                    case '/':
                        result = first_Number / secondNumber;
                        Console.WriteLine("YOUR RESULT IS " + result);
                        break;

                    default:
                        Console.WriteLine("ENTER CORRECT OPERATOR");
                        break;
                }
                
            }

        }
    }
}
