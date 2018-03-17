using iQuarc.DataLocalization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Mvc.Models
{
    [TranslationFor(typeof(Course))]
    public class CourseTranslation
    {
        public int Id { get; set; }
        public int CourseId { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public string Title { get; set; }
    }
}
