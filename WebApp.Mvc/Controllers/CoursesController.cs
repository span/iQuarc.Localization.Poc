using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Mvc.Data;
using WebApp.Mvc.Models;
using WebApp.Mvc.Repositories;

namespace WebApp.Mvc.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursesRepository _repository;

        public CoursesController(ICoursesRepository repository)
        {
            _repository = repository;
        }

        // GET: Courses
        public ViewResult Index()
        {
            var culture = new System.Globalization.CultureInfo("en-UK");
            var courses = _repository.GetCoursesWithSkills(culture);
            return View(courses);
        }
    }
}
