using System;

namespace ConsoleApp1.week_4.day_4
{
    internal class Student
    {
        public int CalculateAverage(int m1,int m2,int m3)
        {
           int  avg = (m1 + m2 + m3) / 3;
            return avg;

        }
        public int CalculateResult(int m1,int m2,int m3,out int total ,out double Avg)
        {
            total = m1+m2+m3;
            Avg = total/3;
            return total;
        }
    }
}
