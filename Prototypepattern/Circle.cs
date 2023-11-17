using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototypepattern
{
	internal class Circle : IShape
	{
		public string Name { get; set; }
		public List<string> Vertices { get; set; }
		public Circle() { }
		public IShape Clone()
		{
			return (Circle)this.MemberwiseClone();
		}
	}
}
