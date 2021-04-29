using MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC.DAL
{
    public class MVCContext : DbContext
    {
        public MVCContext() : base("MVCContext") { }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skills> Skills { get; set; }
    }
}