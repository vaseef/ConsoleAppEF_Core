using ConsoleAppEF_Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEF_Core
{
    class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
            //$"Server=localhost;Port=5432;User Id=mytestdbuser;Password=mytestdb;Database=mytestdb;"
            optionsBuilder.UseNpgsql(@"Server=localhost;Port=5432;User Id=mytestdbuser;Password=mytestdb;Database=SchoolDB;");
        }
    }
}
