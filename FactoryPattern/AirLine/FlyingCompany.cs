using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AirLine
{
	internal abstract class FlyingCompany
	{
		protected IFlying Flying { get; set; }

		public void StartTrip()
		{
			Flying.Destination();
		}
	}
}
