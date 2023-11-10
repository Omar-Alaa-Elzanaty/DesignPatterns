using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public interface IAirPlaneBuilder
	{
		public void Reset();
		public void SetWings(int length);
		public void Sitscount(int count);
		public void CaptainsCount(int count);
	}
}
