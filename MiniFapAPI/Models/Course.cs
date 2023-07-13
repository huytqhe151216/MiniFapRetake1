using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFapAPI.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public int CourseName { get; set; }
        public int SubjectId { get; set; }
        public string LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public Subject Subject { get; set; }
        public List<Student> Students { get; } = new();
        public ICollection<Schedule> Schedules { get; } = new List<Schedule>();
    }
}
