using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Data;
using Store.Models;
using Store.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Areas.Customer.Controllers
{

    [Area("customer")]
    public class OrderController : Controller
    {

        private ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }  

        //Get checkout method

        public IActionResult Checkout()
        {
            return View();
        }

        //Post Action checkout method 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> checkout(Orders onOrder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");

            if(products != null)
            {
                foreach(var product in products)
                {
                    OrdersDetail ordersDetail = new OrdersDetail();
                    ordersDetail.ProductId = product.Id;
                
                    onOrder.ordersDetails.Add(ordersDetail);
                }
            }
            onOrder.OrderN = GetOrderNo();
            _db.Orders.Add(onOrder);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());

            return View();
          
        }
        public string GetOrderNo()
        {
            int rowCount = _db.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }




    }
}
