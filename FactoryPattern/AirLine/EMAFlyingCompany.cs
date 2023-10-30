using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AirLine
{
	internal class EMAFlyingCompany:FlyingCompany
	{
        public EMAFlyingCompany()
        {
            Flying = new ColombiaTravel();
        }
    }
}
