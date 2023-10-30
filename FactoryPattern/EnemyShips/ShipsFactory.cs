using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EnemyShips
{
	internal class ShipsFactory
	{
		public EnemyShip MakeFactory(char identifier)
		{
			EnemyShip ship = null;


			if (identifier == 'D')
			{ 
				 ship = new DannyEnemyShip();
			}
			else if (identifier == 'A')
			{
				 ship = new AvatarEnemyShip();
			}

			return ship;
		}
	}
}
