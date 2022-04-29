using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    public class Semester
    {
        [Key]
        public Guid IdSemester { get; set; }

        [MaxLength(160, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Name { get; set; } = String.Empty;

        [Range(0.0, 10.0)]
        [Column(TypeName = "decimal(4, 2)")]
        public decimal Point { get; set; }
        public StudentInscription? StudentInscription { get; set; }
    }
}
