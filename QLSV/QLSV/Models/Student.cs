using System.ComponentModel.DataAnnotations;

namespace QLSV.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}

