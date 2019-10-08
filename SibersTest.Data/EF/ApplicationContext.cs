using Microsoft.EntityFrameworkCore;
using SibersTest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SibersTest.Data.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        { }
        
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectsPeople> ProjectsPeople { get; set; }
    }
}
