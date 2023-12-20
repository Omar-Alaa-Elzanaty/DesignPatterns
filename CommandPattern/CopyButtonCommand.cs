using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	internal class CopyButtonCommand : ICommand
	{
		public CopyLogic _reciver;

		public CopyButtonCommand(CopyLogic reciver)
		{
			_reciver = reciver;
		}

		public void Execute()
		{
			_reciver.ClickOnCopyButton();
        }
	}
}
