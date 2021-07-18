namespace AstrologyVersusAstronomy.Services
{
	public interface IAstrologyServiceLayer
	{
		public string GetAstrologicalSign(string month, int date);

		public string GetHoroscope(string astrologicalSign);

	}
}
