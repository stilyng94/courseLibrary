using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseLibrary.DataAccess.Models
{
    public class AuthorModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public int FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTimeOffset DateOfBirth { get; set; }
        [Required]
        [MaxLength(50)]
        public string MainCategory { get; set; }
        public ICollection<CourseModel> Courses { get; set; }
            = new List<CourseModel>();
    }
}
