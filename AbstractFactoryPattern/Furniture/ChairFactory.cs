using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Furniture
{
	public class ChairFactory
	{
		protected string ChairName { get; set; }
		public override string ToString()
		{
			return ChairName;
		}
	}
}
