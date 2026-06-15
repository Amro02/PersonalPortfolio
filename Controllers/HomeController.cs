using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using personalportfolio.Models;
using PersonalPortfolio.Models;

namespace personalportfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult About()
    {
        ViewBag.Skills = GetSkills();
        return View();
    }

   private dynamic GetSkills()
   {
      throw new NotImplementedException();
   }

   public IActionResult Projects()
    {
        ViewBag.Projects = GetProjects();
        return View();
    }
    private List<Project> GetProjects()
    {
        return new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "E-Commerce Website",
                Description = "Full-stack e-commerce solution with user authentication, shopping cart, and payment integration.",
                TechStack = "ASP.NET Core, Entity Framework, Bootstrap, JavaScript",
                GitHubUrl = "https://github.com/Amro02/ecommerce-project",
                LiveUrl = "https://demo-ecommerce.com",
                CompletedDate = DateTime.Now.AddMonths(-2),
                IsFeatured = true
            }
            // Add 2-3 more sample projects
        };
    }
    // Add GetSkills() method that returns sample skills data
}
