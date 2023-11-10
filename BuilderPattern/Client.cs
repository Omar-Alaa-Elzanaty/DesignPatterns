using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public class Client
	{
		static Director director = new Director();
		public Client() { }
		public static void RunPublicAirplaneSenario()
		{
			#region Important Logic in pattern
			var builder = new PublicAirPlaneBuilder();
			director.Builder = builder;
			director.BuildClassicAirplane(); 
			#endregion
			Console.WriteLine("wing Length: " + builder.GetBuilder().WingLength); 
            Console.WriteLine("Sit counts: " + builder.GetBuilder().SitsCount); 
            Console.WriteLine("Number of captians: " + builder.GetBuilder().CaptiansCount); 
		}
		public static void RunPrivateAirplaneSenario()
		{
			#region Important Logic in Pattern
			var buildedAirplane = new PublicAirPlaneBuilder();
			director.Builder = buildedAirplane;
			director.BuildModernAirplane(); 
			#endregion
			Console.WriteLine("wing Length: "+buildedAirplane.GetBuilder().WingLength);
            Console.WriteLine("Sit counts: "+buildedAirplane.GetBuilder().SitsCount);
            Console.WriteLine("Number of captians: "+buildedAirplane.GetBuilder().CaptiansCount);
        }
	}
}
