using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Mvc.Models;

namespace WebApp.Mvc.Repositories
{
    public interface ICoursesRepository
    {
        List<Course> GetCoursesWithSkills(CultureInfo culture);
    }
}
