using System.Collections.Generic;

namespace AstrologyVersusAstronomy.Services
{
	public class AstronomyServiceLayer : IAstronomyServiceLayer
	{
		// Use the age and the destination planet to determine the age of the user upon arrival at their
		// planet of choice. You can use estimates like these:
		// https://www.thrillist.com/tech/transit-times-to-planets-how-long-would-it-take-to-get-to-mars
		// or invent your own - you choose!
		// Also, you can use other celestial bodies besides planets, just don't forget to update the destination picker
		// in the Astronomy index.
		public double GetAge(int age, string planet)
		{
			return 0;
		}

		// Decide on what items the traveler will need based on where they're going.
		// For example, if they're going to Mars, maybe they need sunscreen, water, and a beach bucket and shovel.
		// Maybe on Jupiter they need orthopedic shoes - all that gravity!
		// Be creative!
		public List<string> GetSupplies(string planet)
		{
			return new List<string> { 
				"X", 
				"Y", 
				"Z" };
		}
	}
}
