using AstrologyVersusAstronomy.Models;
using AstrologyVersusAstronomy.Services;
using Microsoft.AspNetCore.Mvc;

namespace AstrologyVersusAstronomy.Controllers
{
	public class AstronomyController : Controller
	{
		private IAstronomyServiceLayer astronomyService;

		public AstronomyController(IAstronomyServiceLayer astronomyService)
		{
			this.astronomyService = astronomyService;
		}
		public IActionResult Index()
		{
			return View(new AstronomyModel());
		}

		public IActionResult Destination(AstronomyModel model)
		{
			model.ArrivalAge = astronomyService.GetAge(model.Age, model.Planet);
			model.Supplies = astronomyService.GetSupplies(model.Planet);
			return View(model);
		}
	}
}
