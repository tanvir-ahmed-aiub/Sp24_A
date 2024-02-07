

using FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Person());
        }
        [HttpPost]
        public ActionResult Index(Person p)
        {
            if (ModelState.IsValid) { //checking the rules imposed in Person class
                return RedirectToAction("Contact");
            }
            return View(p);
        }
        //[HttpPost]
        //public ActionResult Index(string Name, string Username, string[] Hobbies)
        //{
            

        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Index(FormCollection fc) {
        //    var name = fc["Name"];
        //    var uname = fc["Username"];
        //    var hobbies = fc["Hobbies"];


        //    return View();
        //}

        public ActionResult Sample() {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}