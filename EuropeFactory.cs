using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyotaAbstractFactory
{
     class EuropeFactory: ToyotaFactory // Concrete Factory 2
        {
        public override Toyota CreateModel() 
        {
            return new CorollaToyota();   //Concrete Product2

        }
    }
}
