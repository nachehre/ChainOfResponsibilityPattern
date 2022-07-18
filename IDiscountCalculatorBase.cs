using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public  abstract  class DiscountCalculatorBase:IDiscountCalculator
    {
        protected IDiscountCalculator Next;

        public abstract double Calculate(Order order);
    
        public  void SetNext(IDiscountCalculator next) 
        {
            Next = next;
        }

    }
}
