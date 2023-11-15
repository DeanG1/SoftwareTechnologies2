using System;

namespace pizzaApp_2101681075
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MeatPizza meatPizza = new MeatPizza();
			meatPizza.MakePizza();

			VeganPizza veganPizza = new VeganPizza();
			veganPizza.MakePizza();

			Console.ReadLine();


		}
	}
}