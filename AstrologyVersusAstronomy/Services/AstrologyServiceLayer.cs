namespace AstrologyVersusAstronomy.Services
{
	public class AstrologyServiceLayer : IAstrologyServiceLayer
	{

		// Use conditionals to determine, and return an astrological sign based on the user's
		// birthdate. Feel free to use the common ones - https://www.britannica.com/topic/zodiac,
		// or invent your own!
		public string GetAstrologicalSign(string month, int dayOfMonth)
		{
            return string.Empty;
		}


		// Use conditionals to determine, then return a horoscope / prediction for the future 
		// based on the astrological sign of the user that you generated in the above method.
		// Be creative!
		public string GetHoroscope(string astrologicalSign)
		{
			return string.Empty;
		}

		
	}
}
