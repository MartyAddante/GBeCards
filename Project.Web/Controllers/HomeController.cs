using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Web.Models;
using Project.Web.DAL;

namespace Project.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserDAL dal;

        public HomeController(IUserDAL userDal)
        {
            this.dal = userDal;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View("Index"); // Homepage that shows list of current holidays in the current month
        }

        public ActionResult HomeMenu()
        {
            HomeModel model = new HomeModel();
            return View("HomeMenu", model);
        }

        [HttpGet]
        public ActionResult Login()
        {            
            return View("Login");
        }
        [HttpGet]
        public ActionResult LoginAlt()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string userName, string passWord)
        {
            
            HomeModel model = new HomeModel();
            if(dal.VerifyUserNameAndPW(userName, passWord) == true)
            {
                return RedirectToAction("HomeMenu", model);
            }
            else
            {
                return RedirectToAction("LoginAlt");
            }
            
        }


        public ActionResult NewUser()
        {
            UserModel newModel = new UserModel();
            return View("NewUser", newModel);
        }
    }
}