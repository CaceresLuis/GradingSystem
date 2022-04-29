using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class Classroom
    {
        [Key]
        public Guid IdClassroom { get; set; }

        [Required]
        [MaxLength(60, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
