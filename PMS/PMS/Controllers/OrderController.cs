using PMS.DTOs;
using PMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class OrderController : Controller
    {
        Sp24_a_PMSEntities db = new Sp24_a_PMSEntities();
        // GET: Order
        public ActionResult Index()
        {
            var data = db.Products.ToList();
            return View(ProductController.Convert(data));
        }
        public ActionResult Addtocart(int id) { 
            var p = db.Products.Find(id);
            var data = ProductController.Convert(p);
            data.Qty = 1;
            List<ProductDTO> products = null;
            if (Session["cart"] == null)
            {
                products = new List<ProductDTO>();
            }
            else {
                products = (List<ProductDTO>)Session["cart"]; //unboxing
            }
            products.Add(data);
            Session["cart"] = products; //boxing
            TempData["Msg"] = data.Name + " Added";
            return RedirectToAction("Index");
        }
        public ActionResult Cart() {
            if (Session["cart"] == null)
            {
                TempData["Msg"] = "Cart Empty";
                return RedirectToAction("Index");

            }
            var products = (List<ProductDTO>)Session["cart"];
            return View(products);
        }

    }
}