using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetablePriceobserver
{
    class Tomato: Vegetable //ConcreteSubject1
    {
        public Tomato(string vegetableName, double price) 
            :base (vegetableName, price) 
        {
            
        }
            
    }
}
