using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaApp_2101681075
{
	class MeatPizza : Pizza
	{
		public override void AddIngredients()
		{
			Console.WriteLine("Add ham, becon , chicken fillet, sausage!");
		}
	}
}
