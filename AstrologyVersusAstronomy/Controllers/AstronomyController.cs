using AstrologyVersusAstronomy.Models;
using AstrologyVersusAstronomy.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstrologyVersusAstronomy.Controllers
{
	public class AstronomyController : Controller
	{
		private IAstronomyServiceLayer dal;

		public AstronomyController(IAstronomyServiceLayer dal)
		{
			this.dal = dal;
		}
		public IActionResult Index()
		{
			return View(new AstronomyModel());
		}

		public IActionResult Destination(AstronomyModel model)
		{
			model.ArrivalAge = dal.GetAge(model.Age, model.Planet);
			model.Supplies = dal.GetSupplies(model.Planet);
			return View(model);
		}
	}
}
