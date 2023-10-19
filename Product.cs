using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilder
{
	class Product
	{
		public int Head { get; set; }
		public int Body { get; set; }
		public int Hands { get; set; }
		public int Legs { get; set; }

		public void PrintInfo()
		{
			Console.WriteLine("Head: {0}", Head);
			Console.WriteLine("Body: {0}", Body);
			Console.WriteLine("Hands: {0}", Hands);
			Console.WriteLine("Legs: {0}", Legs);

		}

	}
}
