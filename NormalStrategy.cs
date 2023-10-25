using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNightBar
{
    public class NormalStrategy:NightBarStrategy  //ConcreteStrategy1
    {
        public override void Calculate(double amount)
        {
            Console.WriteLine(amount + " paid by NormalStrategy");
        }

    }
}
