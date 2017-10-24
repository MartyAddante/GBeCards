using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Web.Models;

namespace Project.Web.Controllers
{
    public class CardsController : Controller
    {
        // GET: Cards
        public ActionResult NewCard()
        {
            CardsModel model = new CardsModel();
            return View("NewCard", model);
        }

        public ActionResult SavedCards()
        {
            SavedCardsModel model = new SavedCardsModel();
            return View("SavedCards", model);
        }

        public ActionResult BackgroundTemplate()
        {
            CardsModel model = new CardsModel();
            return View("BackgroundTemplate", model);
        }
        public ActionResult FontTemplate()
        {
            CardsModel model = new CardsModel();
            return View("FontTemplate", model);
        }
        public ActionResult ImageView()
        {
            CardsModel model = new CardsModel();
            return View("ImageView", model);
        }
        public ActionResult Message()
        {
            CardsModel model = new CardsModel();
            return View("Message", model);
        }
    }
}