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
    //[AdminAccess]
    public class AdminController : Controller
    {
        // GET: Admin
        Sp24_a_PMSEntities db = new Sp24_a_PMSEntities();
        // GET: Order
        public ActionResult Index()
        {
            var data = db.Orders.ToList();
            return View(Convert(data));
        }
       

        public static OrderDTO Convert(Order c)
        {
            return new OrderDTO
            {
                Id = c.Id,
                Date = c.Date,
                UserId = c.UserId,
                Status = c.Status,
                Total = c.Total,
            };
        }
        public static Order Convert(OrderDTO c)
        {
            return new Order
            {
                Id = c.Id,
                Date = c.Date,
                UserId = c.UserId,
                Status = c.Status,
                Total = c.Total,
            };
        }
        public static List<OrderDTO> Convert(List<Order> data)
        {
            var list = new List<OrderDTO>();
            foreach (var item in data)
            {
                list.Add(Convert(item));
            }
            return list;
        }
        public ActionResult Accept(int id)
        {
            var od = db.Orders.Find(id);
            //from o in db.ProductOrders where o.Id = id
            //
            var data = od.ProductOrders;
            foreach (var productOrder in data) {
                productOrder.Product.Qty -= productOrder.Qty;
            }
            od.Status = "Processed";
            db.SaveChanges();
            TempData["Msg"] = "Order Processed";
            return RedirectToAction("Index");
        }
        public ActionResult Decline(int id) {
            var od = db.Orders.Find(id);
            od.Status = "Declined";
            db.SaveChanges();
            TempData["Msg"] = "Order Declined";
            return RedirectToAction("Index");
        }
    }
}