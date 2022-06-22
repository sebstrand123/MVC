using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.DAL
{
    // Klass som skapar tabeller i databasen enligt de modeller jag skapat i mappen Models.
    public class MVCContext : DbContext
    {
        public MVCContext() : base("MVCContext") { }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Person> People { get; set; }
    }
}