using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Mvc.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public List<Skill> Skills { get; set; }

        public List<CourseTranslation> CourseTranslations { get; set; }
    }
}
