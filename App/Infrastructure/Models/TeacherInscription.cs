using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class TeacherInscription
    {
        [Key]
        public Guid IdTeacherInscription { get; set; }
        public Teacher? Teacher { get; set; }
        public Classroom? Classroom { get; set; }
        public Subject? Subject { get; set; }
        public bool IsActive { get; set; }
    }
}
