using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Furniture
{
	public class ClassicFurniture : IFurnitureFactory
	{
		public BedFactory CreateBed()
		{
			return new ClassicBed();
		}

		public ChairFactory CreateChair()
		{
			return new ClassicChair();
		}
	}
}
