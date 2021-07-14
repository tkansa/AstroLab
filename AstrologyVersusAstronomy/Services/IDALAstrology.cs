using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstrologyVersusAstronomy.Services
{
	public interface IDALAstrology
	{
		public string GetAstrologicalSign(string month, int date);

		public string GetHoroscope(string astrologicalSign);

	}
}
