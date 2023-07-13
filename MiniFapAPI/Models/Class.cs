using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniFapAPI.Models
{
    [Table("Class")]
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public ICollection<Student> Students { get; } = new List<Student>();
    }
}
