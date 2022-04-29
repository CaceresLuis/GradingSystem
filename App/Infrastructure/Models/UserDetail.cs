using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class UserDetail
    {
        [Key]
        public Guid IdUserDetail { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }
}
