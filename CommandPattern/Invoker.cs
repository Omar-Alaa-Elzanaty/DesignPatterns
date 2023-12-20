using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	internal class Invoker  //Sender
	{
		private ICommand _command;

		public Invoker(ICommand command)
		{
			_command = command;
		}

		public void InvokeCommand()
		{
			_command.Execute();
		}
	}
}
