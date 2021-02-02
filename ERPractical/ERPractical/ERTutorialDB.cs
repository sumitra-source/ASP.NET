using ERPractical.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPractical
{
    public class ERTutorialDB:DbContext

    {
        public ERTutorialDB(DbContextOptions<ERTutorialDB> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<MarksModel> MarksModel { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarksModel>().HasNoKey();
        }


    }
}
