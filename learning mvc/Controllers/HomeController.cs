using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace learning_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.firstname = "learning mvc asp.net";
            ViewBag.lastname = "from broadway infosys and it4 solutions";
            ViewBag.address = "kathmandu";


            return View();
        }

        
    }
}