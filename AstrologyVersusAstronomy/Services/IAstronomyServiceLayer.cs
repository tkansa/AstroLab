using System;
using System.Collections.Generic;

namespace AstrologyVersusAstronomy.Services
{
	public interface IAstronomyServiceLayer
	{

		public double GetAge(int age, string planet);

		public List<String> GetSupplies(string planet);
	}
}
