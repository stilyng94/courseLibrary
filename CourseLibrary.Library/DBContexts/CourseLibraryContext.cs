using CourseLibrary.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.DataAccess.DBContexts
{
    public class CourseLibraryContext : DbContext, ICourseLibraryContext
    {

        public CourseLibraryContext(DbContextOptions<CourseLibraryContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=courseLibrary;Username=postgres;Password=secret");
        public DbSet<AuthorModel> Authors { get ; set; }
        public DbSet<CourseModel> Courses { get ; set; }

        public new async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
