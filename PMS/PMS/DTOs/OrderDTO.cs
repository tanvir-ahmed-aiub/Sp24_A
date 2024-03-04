using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PMS.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public double Total { get; set; }
        public System.DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}