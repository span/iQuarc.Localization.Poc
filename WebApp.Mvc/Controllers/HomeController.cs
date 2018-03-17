using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Mvc.Data;
using WebApp.Mvc.Models;
using iQuarc.DataLocalization;

namespace WebApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            //var cul = new System.Globalization.CultureInfo("en-UK");
            //var courses = context.Courses
            //    .Select(c => new
            //    {
            //        Id = c.Id,
            //        Title = c.Title,
            //        Skills = context.Skills
            //            .Where(s => s.CourseId== c.Id)
            //            .Select(s => new
            //            {
            //                Id = s.Id,
            //                Name = s.Name
            //            })
            //            .Localize(cul)
            //            .ToList()
            //    })
            //    .Localize(cul)
            //    .First();
            //return new OkObjectResult(courses);
            return View();
        }

        public IActionResult Course()
        {
            var courses = context.Courses;
            return new OkObjectResult(courses);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
