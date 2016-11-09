using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Controllers {
    public class UserController : Controller {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        [HttpGetAttribute]
        public IActionResult Create(User user) {
            //create account
            if (!ModelState.IsValid) return View(user); //backend validation
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPostAttribute]
        public IActionResult Create(Project project) {
            //create project
            if (!ModelState.IsValid) return View(project); //backend validation
            _context.Users.Add(project);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}