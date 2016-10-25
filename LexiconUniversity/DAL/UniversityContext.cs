using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using LexiconUniversity.Models;


namespace LexiconUniversity.DAL
{

    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("UniversityContext")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }        
    }
}