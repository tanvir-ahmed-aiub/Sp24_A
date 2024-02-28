using PMS.DTOs;
using PMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class ProductController : Controller
    {
        Sp24_a_PMSEntities db = new Sp24_a_PMSEntities();
        // GET: Product
        public ActionResult Index()
        {
            var data = db.Products.ToList();
            return View(Convert(data));
        }
        [HttpGet]
        public ActionResult Create()
        {
            var data = db.Categories.ToList();
            ViewBag.Categories = CategoryController.Convert(data);
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductDTO c)
        {
            if (ModelState.IsValid)
            {
                var data = Convert(c);
                db.Products.Add(data);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(c);
        }

        public static ProductDTO Convert(Product c)
        {
            return new ProductDTO
            {
                Id = c.Id,
                Name = c.Name,
                Qty = c.Qty,
                Price = c.Price,
                CId = c.CId,
            };
        }
        public static Product Convert(ProductDTO c)
        {
            return new Product
            {
                Id = c.Id,
                Name = c.Name,
                Qty = c.Qty,
                Price = c.Price,
                CId = c.CId,
            };
        }
        public static List<ProductDTO> Convert(List<Product> data)
        {
            var list = new List<ProductDTO>();
            foreach (var item in data)
            {
                list.Add(Convert(item));
            }
            return list;
        }
    }
}