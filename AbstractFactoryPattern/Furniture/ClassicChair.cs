using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Furniture
{
	internal class ClassicChair:ChairFactory
	{
        public ClassicChair()
        {
            ChairName = "Classic Chair";
        }
    }
}
