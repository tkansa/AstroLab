using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstrologyVersusAstronomy.Services
{
	public interface IDALAstronomy
	{

		public double GetAge(int age, string planet);

		public List<String> GetSupplies(string planet);
	}
}
