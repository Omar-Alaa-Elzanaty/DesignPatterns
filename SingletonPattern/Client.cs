using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SingletonPattern
{
	public class Client
	{
		//Manager manager = new Manager();  compilation error

		public static void RunManagerSenario()
		{
			Manager manager1 = Manager.CreateObject();
			Manager manager2 = Manager.CreateObject();

			Console.WriteLine("Manager1:  " + manager1.GetHashCode() + "\n");
			Console.WriteLine("Manager2:  " + manager2.GetHashCode() + "\n");
        }
	}
}
