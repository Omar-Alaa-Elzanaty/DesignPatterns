using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
	public class PublicAirPlaneBuilder : IAirPlaneBuilder
	{
		private publicAirPlane _result;
        public PublicAirPlaneBuilder()
        {
			this.Reset();
        }
        public void CaptainsCount(int count)
		{
			_result.CaptiansCount = count + 3;
		}

		public publicAirPlane GetBuilder()
		{
			var airplane = _result;
			return airplane;
		}

		public void Reset()
		{
			_result=new publicAirPlane();
		}

		public void SetWings(int length)
		{
			_result.WingLength = length + 5;
		}

		public void Sitscount(int count)
		{
			_result.SitsCount = count;
		}
	}
}
