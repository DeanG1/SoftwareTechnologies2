using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilder
{
	abstract class Builder
	{
		public abstract void BuildHead();
		public abstract void BuildBody();
		public abstract void BuildHands();

		public abstract void BuildLegs();

		public abstract Product GetProduct();
	}
}
