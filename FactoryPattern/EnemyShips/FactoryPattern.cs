using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EnemyShips
{
	public class FactoryPattern
	{
		public void RunSenario1()
		{
			ShipsFactory factory=new ShipsFactory();

            Console.WriteLine("Enter D / A");
			char x = Console.ReadLine().ToCharArray()[0];

			var ship = factory.MakeFactory(x);

			if (ship != null)
			{
				ship.Attack();
				ship.Defence();
			}
		}
	}
}
