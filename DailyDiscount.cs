using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DailyDiscount : DiscountCalculatorBase
    {
        public override double Calculate(Order order)
        {
            if (order.Price < 500 )
            {
                return (order.Price * 0.05);
            }
            else
            {
                if (Next == null)
                    return 0;
                else
                    return Next.Calculate(order);
            }
        }
    }
}
