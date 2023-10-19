using System;

namespace RobotBuilder
{
	public class Program
	{

		static void Main(string[] args) 
		{
			Director director = new Director();
			Builder newRobotBuilder = new NewRobotBuilder();
			director.Construct(newRobotBuilder);

			newRobotBuilder.GetProduct().PrintInfo();

			Builder oldRobotBuilder = new OldRobotBuilder();
			director.Construct(oldRobotBuilder);

			oldRobotBuilder.GetProduct().PrintInfo();

			Console.ReadKey();
		
		}
	}

}