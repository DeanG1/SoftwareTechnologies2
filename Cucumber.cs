using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetablePriceobserver
{
    class Cucumber : Vegetable //ConcreteSubject1
    {
        public Cucumber(string vegetableName, double price)
            : base(vegetableName, price)
        {

        }

    }
}