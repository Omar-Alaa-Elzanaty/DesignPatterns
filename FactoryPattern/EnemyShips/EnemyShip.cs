using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.EnemyShips
{
	internal abstract class EnemyShip
	{
		public string Name { get; set; }
		public int Health { get; set; }
		public void Attack()
		{
			Console.WriteLine($"{Name}, Attack now");
			Console.WriteLine($"{Name}, Health = {Health}");
			Console.WriteLine();
        }
		public void Defence()
		{
			Console.WriteLine($"{Name}, Defence now");
			Console.WriteLine($"{Name}, Health = {Health-1}");
		}
	}
}
