using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Mvc.Models;

namespace WebApp.Mvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        static ApplicationDbContext()
        {
            iQuarc.DataLocalization.LocalizationConfig.RegisterLocalizationEntity<Language>(l => l.IsoCode);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTranslation> CourseTranslations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillTranslation> SkillTranslations { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
