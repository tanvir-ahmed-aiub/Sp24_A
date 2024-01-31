using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login() {

            return View();
        }
        public ActionResult SignUp() {
            return View();
        }
        public ActionResult Submit() {
            //validation
            //authentication
            //if ok
            return Redirect("https://portal.aiub.edu");
            //return RedirectToAction("Profile","Dashboard");
        }
        
    }
}