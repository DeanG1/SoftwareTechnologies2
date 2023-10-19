using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilder
{
	class OldRobotBuilder : Builder
	{
		public Product product = new Product();

		public override void BuildHead()
		{
			product.Head = 1;
		}
		public override void BuildBody()
		{
			product.Body = 1;
		}
		public override void BuildHands()
		{
			product.Hands = 2;
		}
		public override void BuildLegs()
		{
			product.Legs = 2;
		}
		public override Product GetProduct()
		{
			return product;
		}
	}
}
