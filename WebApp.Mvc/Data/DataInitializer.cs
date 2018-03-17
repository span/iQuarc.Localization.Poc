using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Mvc.Models;

namespace WebApp.Mvc.Data
{
    public static class DataInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any courses.
            if (!context.Courses.Any())
            {
                var courses = new Course[]
{
                new Course
                {
                    Title = "Course 1",
                    Skills = new List<Skill>
                    {
                        new Skill { Name = "Skill 1" },
                        new Skill { Name = "Skill 2" }
                    }
                },
                new Course
                {
                    Title = "Course 2",
                    Skills = new List<Skill>
                    {
                        new Skill { Name = "Skill 3" },
                        new Skill { Name = "Skill 4" }
                    }
                },
};
                context.Courses.AddRange(courses);
                context.SaveChanges();
            }

            if (!context.Languages.Any())
            {
                var englishLanguage = new Language { Name = "English", IsoCode = "en" };
                var swedishLanguage = new Language { Name = "Swedish", IsoCode = "sv" };
                var languages = new Language[] { englishLanguage, swedishLanguage };
                context.Languages.AddRange(languages);
                context.SaveChanges();

                var courseTranslations = new CourseTranslation[]
                {
                    new CourseTranslation
                    {
                        CourseId = 1,
                        LanguageId = 1,
                        Title = "Course 1 - en"
                    },
                    new CourseTranslation
                    {
                        CourseId = 1,
                        LanguageId = 2,
                        Title = "Course 1 - sv"
                    },
                    new CourseTranslation
                    {
                        CourseId = 2,
                        LanguageId = 1,
                        Title = "Course 2 - en"
                    },
                    new CourseTranslation
                    {
                        CourseId = 2,
                        LanguageId = 2,
                        Title = "Course 2 - sv"
                    }
                  };

                context.CourseTranslations.AddRange(courseTranslations);
                context.SaveChanges();

                var skillTranslations = new SkillTranslation[]
                {
                    new SkillTranslation
                    {
                        SkillId = 1,
                        LanguageId = 1,
                        Name = "Skill 1 - en"
                    },
                    new SkillTranslation
                    {
                        SkillId = 2,
                        LanguageId = 1,
                        Name = "Skill 2 - en"
                    }
                };

                context.SkillTranslations.AddRange(skillTranslations);
                context.SaveChanges();
            }
        }
    }
}
