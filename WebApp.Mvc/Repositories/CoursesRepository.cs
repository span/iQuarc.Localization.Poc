using iQuarc.DataLocalization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Mvc.Data;
using WebApp.Mvc.Models;

namespace WebApp.Mvc.Repositories
{
    public class CoursesRepository : ICoursesRepository
    {
        private ApplicationDbContext _context;

        public CoursesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Course> GetCoursesWithSkills(CultureInfo culture)
        {
            var courses = _context.Courses
                .Select(c => new Course
                {
                    Id = c.Id,
                    Title = c.Title,
                    Skills = _context.Skills
                        .Where(s => s.CourseId == c.Id)
                        .Select(s => new Skill
                        {
                            Id = s.Id,
                            Name = s.Name
                        })
                        .ToList()
                })
                .Localize(culture)
                .ToList();
            return courses;
        }
    }
}
