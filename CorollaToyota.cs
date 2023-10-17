using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyotaAbstractFactory
{
    class CorollaToyota : Toyota
    {
        public override string Name
        {
            get { return "Toyota Corolla"; }
        }
        public override string Model
        {
            get { return "Corolla"; }
        }
        public override string EngineType
        {
            get { return "Benzin"; }
        }

        public override string Color
        {
            get { return "red"; }
        }

        public override void Print()
        {
            Console.WriteLine("The brand of my car is: {0}", Name);
            Console.WriteLine("The model is: {0}", Model);
            Console.WriteLine("The engine type is: {0}", EngineType);
            Console.WriteLine("The color is: {0}", Color);
        }

    }
}

