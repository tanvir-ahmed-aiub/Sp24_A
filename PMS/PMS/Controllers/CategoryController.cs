using PMS.DTOs;
using PMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class CategoryController : Controller
    {
        Sp24_a_PMSEntities db = new Sp24_a_PMSEntities();
        // GET: Category
        public ActionResult Index()
        {
            var data = db.Categories.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create() { 
            return View();
        }
        [HttpPost]
        public ActionResult Create(CategoryDTO c) {
            if (ModelState.IsValid) {
                var data = Convert(c);
                db.Categories.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(c);
        }

        public static CategoryDTO Convert(Category c) {
            return new CategoryDTO { 
                Id = c.Id,
                Name = c.Name,          
            };
        }
        public static Category Convert(CategoryDTO c)
        {
            return new Category
            {
                Id = c.Id,
                Name = c.Name,
            };
        }
        public static List<CategoryDTO> Convert(List<Category> data) { 
            var list = new List<CategoryDTO>();
            foreach (var item in data) { 
                list.Add(Convert(item));
            }
            return list;
        }
    }
}