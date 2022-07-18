using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DiscountCalculator : IDiscountCalculator
    {
        public double Calculate(Order order)
        { ///daily discount
            if (order.Price < 500 && order.Price >200)
            {
                return (order.Price * 0.05);
            }
            ///ordinary discout
            if (order.Price > 500 && order.Price<1000)
            {
                return (order.Price * 0.1);
            }

            ///vip discount
            if (order.Price > 1000)
            {
                return (order.Price * 0.15);
            }
            else
            {
                return 0;
            }
        }
    }
}
