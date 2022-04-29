using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class StudentInscription
    {
        [Key]
        public Guid IdStudentInscription { get; set; }
        public TeacherInscription? TeacherInscription { get; set; }
        public Student? Student { get; set; }
        public bool IsActive { get; set; }
    }
}
