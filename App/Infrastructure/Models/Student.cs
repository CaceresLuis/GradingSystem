using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class Student
    {
        [Key]
        public Guid IdStudent { get; set; }
        public UserDetail? UserDetail { get; set; }
    }
}
