using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6handson.day2
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double amount);

    }

    public class RegularCostmerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return ((amount/100)*5);
        }
    }

    public class PremiumCustomerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return ((amount/100)*10);
        }
    }

    public class VipCustomerDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double amount)
        {
            return ((amount/100)*15);
        }
    }

    public class FinalCalculator
    {
        private readonly IDiscountStrategy discountStrategy;

        public FinalCalculator(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public double FinalPrice(double amount)
        {
            var dis= discountStrategy.CalculateDiscount(amount);
            return amount - dis;
        }
    }


}


