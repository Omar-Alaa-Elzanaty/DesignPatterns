using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public class Director
	{
		public IAirPlaneBuilder Builder;
		public Director() { }
		public void BuildClassicAirplane() {
			Builder.SetWings(5);
			Builder.Sitscount(10);
			Builder.CaptainsCount(3);
		}
		public void BuildModernAirplane()
		{
			Builder.SetWings(1000);
			Builder.Sitscount(5000);
			Builder.CaptainsCount(20);
		}
	}
}
