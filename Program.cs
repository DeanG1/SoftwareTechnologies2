using System;

namespace TransportBuilder
{
	public class Program
	{

		static void Main(string[] args)
		{
			Director director = new Director();
			Builder carBuilder = new CarBuilder();
			director.Construct(carBuilder);

			carBuilder.GetProduct().PrintInfo();

			Builder motorBuilder = new MotorBuilder();
			director.Construct(motorBuilder);

			motorBuilder.GetProduct().PrintInfo();

			Console.ReadKey();

		}
	}

}