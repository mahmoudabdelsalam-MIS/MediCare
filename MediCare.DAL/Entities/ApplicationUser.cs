using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class ApplicationUser
    {
        [Key]
        public int UserId { get; set; }

        [Required, MaxLength(150)]
        public string FullName { get; set; } = string.Empty;

        [Required, EmailAddress, MaxLength(150)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? Phone { get; set; }

        [Required, MaxLength(50)]
        public string Role { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string AccountStatus { get; set; } = "Active";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties (1:1)
        public Doctor? Doctor { get; set; }
        public Patient? Patient { get; set; }
    }
}