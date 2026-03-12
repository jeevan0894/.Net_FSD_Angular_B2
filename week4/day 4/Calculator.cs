using System;

namespace ConsoleApp1.week_4.day_4
{
    internal class Calculator
    {
        public int Add(int x,int y)
        {
            return x + y;
        }
        public int Substraction(int x,int y)
        {
            return x - y;
        }

        public double CalculateFinalAmount(double PdtPrice,int Qty,double disc=0,double ComCharge = 50)
        {
            double SubTotal=PdtPrice*Qty;
            double DiscPrice = SubTotal / 100 * disc;
            double AfterDiscAmount = SubTotal - DiscPrice;
            double TotalAmountToPay=AfterDiscAmount+ComCharge;
            return TotalAmountToPay;
        }

    }
}
