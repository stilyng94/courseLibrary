using CourseLibrary.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseLibrary.DataAccess.Repositories
{
    public interface ICourseLibraryRepository
    {
        Task<int> AddCourse(Guid authorId, CourseModel course);
        Task<int> UpdateCourse(Guid courseId, CourseModel course);
            
    }
}
