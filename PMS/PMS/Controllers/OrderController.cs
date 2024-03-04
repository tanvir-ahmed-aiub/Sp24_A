using PMS.Auth;
using PMS.DTOs;
using PMS.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    [Logged]
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
        [HttpPost]
        public ActionResult Place(double Total) {
            var order = new Order();
            order.Total = Total;
            order.Status = "Ordered";
            order.UserId = ((User)Session["user"]).Id;
            order.Date = DateTime.Now;
            db.Orders.Add(order);
            db.SaveChanges();
            var cart = (List<ProductDTO>)Session["cart"];
            foreach (var item in cart) {
                var pd = new ProductOrder();
                pd.Price = item.Price;
                pd.Qty = item.Qty;
                pd.OId = order.Id;
                pd.PId = item.Id;
                db.ProductOrders.Add(pd);
            }
            db.SaveChanges();
            TempData["Msg"] = "Order Placed with id "+order.Id;
            Session["cart"] = null;
            return RedirectToAction("Index");
            
        }
    }
}