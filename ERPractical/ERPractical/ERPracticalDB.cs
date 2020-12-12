using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPractical
{
    public class ERPracticalDB:DbContext

    {
        public ERPracticalDB(DbContextOptions<ERPracticalDB> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Student> Students { get; set; }

    }
}
