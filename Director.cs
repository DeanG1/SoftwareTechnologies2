using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBuilder
{
     class Director
    {
        public void Construct(Builder builder) 
        {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildDoors();
            builder.BuildWheels();

        }
    }
}
