

using FormSubmission.EF;
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
            ViewBag.Layout = "This is for Layout from Action";
            return View(new Person());
        }
        [HttpPost]
        public ActionResult Index(User p)
        {
            if (ModelState.IsValid) { //checking the rules imposed in Person class
                //TempData["Msg"] = "Form is valid";
                var db = new Sp24_aEntities();
                db.Users.Add(p);
                db.SaveChanges();   
                return RedirectToAction("Contact");
            }
            return View(p);
        }
        public ActionResult List() {
            var db = new Sp24_aEntities();

            var users = (from st in db.Users
            where st.Roll>=1 && st.Roll <=20
            select st).ToList();

            //var users = db.Users.ToList();
            return View(users);
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