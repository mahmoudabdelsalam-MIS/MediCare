using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class Specialization
    {
        [Key]
        public int SpecializationId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        // Navigation Property (1:N)
        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}