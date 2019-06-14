using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BirthdayCard.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			return View();
        }

		[HttpGet]
		public ActionResult BirthdayCardForm()
		{
			return View();
		}

		[HttpPost]
		public ActionResult BirthdayCardForm(Models.BirthCardInfo birthdayCardInfo)
		{
			if (ModelState.IsValid)
			{
				return View("CardSent", birthdayCardInfo);
			}
			else
			{
				return View();
			}
		}
	}
}