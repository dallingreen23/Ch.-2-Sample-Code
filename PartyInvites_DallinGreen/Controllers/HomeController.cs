using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites_DallinGreen.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int HOUR = DateTime.Now.Hour;
            ViewBag.Greeting = Hour < 12 ? "Good Morning" : "Good Afternoon"
            return View();
        }
    }
}