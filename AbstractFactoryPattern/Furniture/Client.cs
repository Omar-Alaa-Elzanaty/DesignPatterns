using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Furniture
{
	public class Client
	{

		public Client()
		{
		}
		public static  void RunSenarioFurnitureSenario(IFurnitureFactory factory)
		{
            Console.WriteLine(factory.CreateBed());
			Console.WriteLine(factory.CreateChair());
        }
	}
}
