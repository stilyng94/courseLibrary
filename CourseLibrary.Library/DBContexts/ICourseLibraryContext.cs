using CourseLibrary.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.DataAccess.DBContexts
{
    public interface ICourseLibraryContext
    {
        DbSet<AuthorModel> Authors { get; set; }
        DbSet<CourseModel> Courses { get; set; }

        Task<int> SaveChanges();

    }
}
