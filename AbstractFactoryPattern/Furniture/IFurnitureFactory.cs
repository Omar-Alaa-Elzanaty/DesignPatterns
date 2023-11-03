using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Furniture
{
	public interface  IFurnitureFactory
	{
		public abstract ChairFactory CreateChair();
		public abstract BedFactory CreateBed();
	}
}
