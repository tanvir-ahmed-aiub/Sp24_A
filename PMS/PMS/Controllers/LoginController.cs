using PMS.DTOs;
using PMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class LoginController : Controller
    {
        Sp24_a_PMSEntities db = new Sp24_a_PMSEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginDTO l) {
            var user = (from u in db.Users
                        where u.Uname.Equals(l.Uname)
                        && u.Pass.Equals(l.Pass)
                        select u).SingleOrDefault();
            if (user != null) {
                Session["user"] = user;
                if (user.Type.Equals("Admin")) {
                    return RedirectToAction("Index","Admin");
                }

                return RedirectToAction("Index", "Order");
                
            }
            TempData["Msg"] = "Invalid username and password";
            return RedirectToAction("Index");

        }
    }
}