using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CourseLibrary.DataAccess.Models
{
    public class CourseModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public int Title { get; set; }
        [MaxLength(1500)]
        public string Description { get; set; }
        [ForeignKey("AuthorId")]
        public AuthorModel Author { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
       
    }
}
