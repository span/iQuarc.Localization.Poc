using iQuarc.DataLocalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Mvc.Models
{
    [TranslationFor(typeof(Skill))]
    public class SkillTranslation
    {
        public int Id { get; set; }
        public int SkillId { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public string Name { get; set; }
    }
}
