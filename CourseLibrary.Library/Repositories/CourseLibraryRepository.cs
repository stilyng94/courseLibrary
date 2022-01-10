using CourseLibrary.DataAccess.DBContexts;
using CourseLibrary.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.DataAccess.Repositories
{
    public class CourseLibraryRepository : ICourseLibraryRepository, IDisposable
    {

        private readonly CourseLibraryContext _context;
        public CourseLibraryRepository(CourseLibraryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Task<int> AddCourse(Guid authorId, CourseModel course)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateCourse(Guid courseId, CourseModel course)
        {
            throw new NotImplementedException();
        }
    }
}
