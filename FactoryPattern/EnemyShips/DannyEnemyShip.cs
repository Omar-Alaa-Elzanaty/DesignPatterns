using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EnemyShips
{
	internal class DannyEnemyShip:EnemyShip
	{
        public DannyEnemyShip()
        {
            Name = "Danny Ship";
            Health = 50;
        }
    }
}
