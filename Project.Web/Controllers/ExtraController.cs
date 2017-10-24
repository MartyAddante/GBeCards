using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Web.Models;

namespace Project.Web.Controllers
{
    public class ExtraController : Controller
    {
        // GET: Extra
        public ActionResult Calendar()
        {
            CardsModel model = new CardsModel();
            return View("Calendar", model);
        }

        public ActionResult CardOfTheDay()
        {
            CardsModel model = new CardsModel();
            return View("CardOfTheDay", model);
        }
    }
}