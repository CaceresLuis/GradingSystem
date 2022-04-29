using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models
{
    public class Admin
    {
        [Key]
        public Guid IdAdmin { get; set; }
        public UserDetail? UserDetail { get; set; }
    }
}
