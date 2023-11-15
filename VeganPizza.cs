using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace pizzaApp_2101681075
{
	class VeganPizza : Pizza   //ConcreteClass1
	{
		public override void AddIngredients()
		{
			Console.WriteLine("Add tomato, onion, spinach, arugula, corn, pepper and peas!");
		}
	
	}
}
