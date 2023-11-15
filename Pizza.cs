using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaApp_2101681075
{
	abstract class Pizza  //AbstractClass
	{
		public void MakePizza()  //TemplateMethod
		{
			MakeDough();
			AddTomatoSauce();      //PrimitiveOperation1
			AddCheese();
			AddIngredients();            //PrimitiveOperation2
		}

		public void MakeDough()
		{
			Console.WriteLine("Dough is ready!");
		}

		public void AddTomatoSauce() {
			Console.WriteLine("The tomato sauce is added!");
		}

		public void AddCheese()
		{
			Console.WriteLine("The cheese is added!");
		}
		public abstract void AddIngredients();
	}
}
