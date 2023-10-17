using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyotaAbstractFactory
{
    abstract class Toyota // AbstractProduct
    {
        public abstract string Name { get; }
        public abstract string Model { get; }
        
        public abstract string EngineType { get; }

        public abstract string Color { get; }

        public abstract void Print();
    }
}
