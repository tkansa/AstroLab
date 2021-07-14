using AstrologyVersusAstronomy.Models;
using AstrologyVersusAstronomy.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstrologyVersusAstronomy.Controllers
{
	public class AstrologyController : Controller
	{
		private IDALAstrology dal;

		public AstrologyController(IDALAstrology dal)
		{
			this.dal = dal;
		}
		public IActionResult Index()
		{
			return View(new AstrologyModel());
		}

		public IActionResult Horoscope(AstrologyModel model)
		{
			model.AstrologicalSign = dal.GetAstrologicalSign(model.BirthMonth, model.BirthDay);
			model.Horoscope = dal.GetHoroscope(model.AstrologicalSign);
			return View(model);
		}
	}
}
