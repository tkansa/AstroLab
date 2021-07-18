using AstrologyVersusAstronomy.Models;
using AstrologyVersusAstronomy.Services;
using Microsoft.AspNetCore.Mvc;

namespace AstrologyVersusAstronomy.Controllers
{
	public class AstrologyController : Controller
	{
		private IAstrologyServiceLayer astrologyService;

		public AstrologyController(IAstrologyServiceLayer astrologyService)
		{
			this.astrologyService = astrologyService;
		}
		public IActionResult Index()
		{
			return View(new AstrologyModel());
		}

		public IActionResult Horoscope(AstrologyModel model)
		{
			model.AstrologicalSign = astrologyService.GetAstrologicalSign(model.BirthMonth, model.BirthDay);
			model.Horoscope = astrologyService.GetHoroscope(model.AstrologicalSign);
			return View(model);
		}
	}
}
