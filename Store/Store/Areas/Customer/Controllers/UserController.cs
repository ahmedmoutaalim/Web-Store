﻿using Microsoft.AspNetCore.Identity;
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
    public class UserController : Controller
    {
        private UserManager<IdentityUser> _userManager;

        private ApplicationDbContext _db;

        public UserController(UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            var dd = _userManager.GetUserId(HttpContext.User);
            return View(_db.ApplicationUsers.ToList());

        }
        public async Task<IActionResult>Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded)
                {
                  /*  var isSaveRole = await _userManager.AddToRoleAsync(user, "User");*/
                    TempData["save"] = "User has been created successfully";
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }


            return View();

        }
    }
}
