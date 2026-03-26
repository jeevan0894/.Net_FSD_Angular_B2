using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6handson.day2
{
    internal class IDiscountStrategyMain
    {
        public static void Main()
        {
            double amount = 1000;
            IDiscountStrategy regular = new RegularCostmerDiscount();
            IDiscountStrategy premium = new PremiumCustomerDiscount();
            IDiscountStrategy vip=new VipCustomerDiscount();

            FinalCalculator cal1 = new FinalCalculator(regular);
            FinalCalculator cal2 = new FinalCalculator(premium);
            FinalCalculator cal3=new FinalCalculator(vip);

            Console.WriteLine($"regular costumer{cal1.FinalPrice(amount)}");
            Console.WriteLine($"premium costumer{cal2.FinalPrice(amount)}");
            Console.WriteLine($"vip costumer{cal3.FinalPrice(amount)}");


        }

    }
}
