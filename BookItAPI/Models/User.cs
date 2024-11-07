using System.ComponentModel.DataAnnotations;

namespace BookitAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public required string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public required string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Email { get; set; }
    }
}