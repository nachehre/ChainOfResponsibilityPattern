using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            order.Price = 700;

            var vip = new VipDiscount();

            var ordinary = new OrdinaryDiscount();
            ordinary.SetNext(vip);

            var daily = new DailyDiscount();
             daily.SetNext(ordinary);

            daily.Calculate(order);


        }
    }
}
