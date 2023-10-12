using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBuilder
{
    class Product
    {
        public string Frame { get; set; }
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }

        public void PrintInfo() 
        {
            Console.WriteLine("Frame: {0}", Frame);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Doors: {0}", Doors);
            Console.WriteLine("Wheels: {0}", Wheels);
            
        }

    }
}
