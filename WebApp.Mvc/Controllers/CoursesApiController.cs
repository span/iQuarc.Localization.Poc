using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iQuarc.DataLocalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Mvc.Data;
using WebApp.Mvc.Models;
using WebApp.Mvc.Repositories;

namespace WebApp.Mvc.Controllers
{
    [Produces("application/json")]
    [Route("api/Courses")]
    public class CoursesApiController : Controller
    {
        private readonly ICoursesRepository _repository;

        public CoursesApiController(ICoursesRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Courses
        [HttpGet]
        public IActionResult GetCourses()
        {
            var culture = new System.Globalization.CultureInfo("en-UK");
            var courses = _repository.GetCoursesWithSkills(culture);
            return new OkObjectResult(courses);
        } 
    }
}