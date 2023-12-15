using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
	internal class Manager
	{
		private static Manager _instance;
		private Manager()
		{

		}
		public static Manager CreateObject()
		{
			if (_instance == null)
				return _instance = new Manager();

			return _instance;
		}
	}
}
