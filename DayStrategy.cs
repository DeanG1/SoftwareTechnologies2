using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNightBar
{
    public class DayStrategy : NightBarStrategy
    {
        public override void Calculate(double amount)
        {
            Console.WriteLine(amount / 2 + "paid by DayStrategy");
        }
    }
}
