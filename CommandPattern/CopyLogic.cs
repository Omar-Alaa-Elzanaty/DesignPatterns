using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
	internal class CopyLogic	//Reciver  //Lowest layer
	{
		public void ClickOnCopyButton()
		{
			Console.WriteLine("Copy button pressed");
		}
	}
}
