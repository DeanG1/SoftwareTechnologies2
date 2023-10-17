using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyotaAbstractFactory
{
    class JapanFactory:ToyotaFactory    // ConctreteFactory1
    {
        public override Toyota CreateModel()
        {   
            return new PriusToyota();   //Concrete Product1
        }

    }
}
