using Microsoft.AspNetCore.MVC;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using ForgingAhead.Models;

namespace ForgingAhead.Controllers {
    public class CharacterController : Controller {
        private readonly ApplicationDbContext _context;

        public CharacterController(ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult Create(Character character) {
            _context.Characters.Add(character);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}