using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class Teacher
    {
        [Key]
        public Guid IdTeacher { get; set; }
        public UserDetail? UserDetail { get; set; }
    }
}
