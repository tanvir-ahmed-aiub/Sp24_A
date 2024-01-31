using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IntroMVC.Models;

namespace IntroMVC.Controllers
{
    public class DashboardController : Controller
    {
        public ActionResult Profile() {
            var s1 = new Student();
            s1.Name = "Tanvir";
            s1.Id = 1;
            s1.Cgpa = 2.34f;

            var s2 = new Student();
            s2.Name = "Sabbir";
            s2.Id = 2;
            s2.Cgpa = 3.45f;

            var students = new Student[] { s1, s2 };

            ViewBag.Students = students;


            //string name = "Tanvir";
            //string id = "123";
            //float cgpa = 2.34f;

            //ViewBag.Name = name;
            //ViewBag.Id = id;
            //ViewBag.Cgpa = cgpa;
            return View();
        }
        
    }
}