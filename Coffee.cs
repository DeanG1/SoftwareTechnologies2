using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HotDrink
{
     class Coffee : HotDrink     //ConcreteClass1
    {
        public override void AddMainIngredient()
        {
            Console.WriteLine("Adding Coffee...");
        }
        public override void AddSupplement()
        {
            Console.WriteLine("Adding cream, sugar and milk...");
        }

    }
}
