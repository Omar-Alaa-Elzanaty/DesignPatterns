using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AirLine
{
	internal class ParisTravel : IFlying
	{
		public void Destination()
		{
            Console.WriteLine("Flying to Paris");
        }
	}
}
