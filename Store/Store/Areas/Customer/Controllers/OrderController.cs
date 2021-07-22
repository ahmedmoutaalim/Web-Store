using Microsoft.AspNetCore.Mvc;
using Store.Data;
using Store.Models;
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
            db = _db  ;
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

            return View();
        }

        public string GetOrderN()
        {
            var rowCount = _db.Orders.ToList().Count() + 1;

            return rowCount.ToString("000");

        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
