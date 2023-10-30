using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AirLine
{
	internal class CairoFlyingCompany:FlyingCompany
	{
        public CairoFlyingCompany()
        {
            Flying = new ParisTravel();
        }
    }
}
