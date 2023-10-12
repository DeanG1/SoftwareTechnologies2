using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBuilder
{
    class MotorBuilder: Builder  //ConcreteBuilder2
    {
        public Product product = new Product();
        public override void BuildFrame()
        {
            product.Frame = "Motor frame";
        }
        public override void BuildEngine()
        {
            product.Engine = "50 cc";
        }
        public override void BuildDoors()
        {
            product.Doors = 0;
        }
        public override void BuildWheels()
        {
            product.Wheels = 2;
        }
        public override Product GetProduct()
        {
            return product; 
        }
    }
}
