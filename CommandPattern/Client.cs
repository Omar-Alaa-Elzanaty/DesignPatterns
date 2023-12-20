using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	public class Client
	{
		public static void RunSenario()
		{
			ICommand command = new CopyButtonCommand(new CopyLogic());
			Invoker invoke = new Invoker(command);
			invoke.InvokeCommand();
		}
	}

}
