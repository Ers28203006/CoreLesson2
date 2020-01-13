using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreLesson2.Models
{
    public class StudentContext :DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

        public StudentContext(DbContextOptions options): base (options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllocaldb; Database=StudentDB; Trusted_Connection=True;");
        //}
    }
}
