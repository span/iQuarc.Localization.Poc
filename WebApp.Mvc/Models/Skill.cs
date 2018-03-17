using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Mvc.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public int CourseId { get; set; }

        public string Name { get; set; }

        public List<SkillTranslation> SkillTranslations { get; set; }
    }
}
