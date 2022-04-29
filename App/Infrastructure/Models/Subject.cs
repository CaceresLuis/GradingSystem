using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class Subject
    {
        [Key]
        public Guid IdSubject { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Name { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
