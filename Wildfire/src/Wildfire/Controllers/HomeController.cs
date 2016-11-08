using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wildfire.Models;

namespace Wildfire.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Login(string Login, string Password)
        {
            ViewData["Message"] = "Login";

            var model = new Wildfire.Models.User();
            model.Login = Login;
            model.Password = Password;
            return View("Login", model);
        }

        public IActionResult Register()
        {

            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Idea(/*info about the idea from the create a project form*/)
        {
            ViewData["Message"] = "Create a Project: Step 1 General Information";
            //statement to add project informaton to database

            return View(/*view page with project info*/"Idea_form");
        }

        public IActionResult IdeaFinanceView(Idea model)
        {
            ViewData["Message"] = "Create a Project: Step 2 Finance";
            //statement to add project informaton to database

            return View(/*view page with project info*/"Idea_view", model);
        }

        public IActionResult IdeaView(string Category, string Title, string Description)
        {
            var model = new Wildfire.Models.Idea();
            model.Category = Category;
            model.Title = Title;
            model.Description = Description;
            //progress bar
            var model2 = new Wildfire.Models.Idea();
            return View("Idea_finance_form", model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
