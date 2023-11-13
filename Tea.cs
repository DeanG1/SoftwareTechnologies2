using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrink
{
    class Tea : HotDrink
    {
        public override void AddMainIngredient() 
        {
            Console.WriteLine("Adding Tea...");
        }
        public override void AddSupplement()
        {
            Console.WriteLine("Adding sugar and honey...");
        }
    }
}
