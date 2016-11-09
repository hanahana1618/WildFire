using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication.Models;
using Microsoft.AspNetCore;
using WebApplication.Data;

namespace WebApplication.Controllers {
    public class PlayerController : Controller {
        private readonly ApplicationDbContext _context;

        public PlayerController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Index() {
            return View();
        }

        [HttpGetAttribute]
        public IActionResult Create(Player player) {
            //create account
            if (!ModelState.IsValid) return View(player); //backend validation
            _context.Users.Add(player);
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