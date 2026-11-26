using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        // Foreign Key
        public int UserId { get; set; }

        public DateOnly DateOfBirth { get; set; }

        [MaxLength(20)]
        public string? Gender { get; set; }

        [MaxLength(300)]
        public string? Address { get; set; }

        [MaxLength(50)]
        public string? EmergencyContact { get; set; }

        // Navigation Properties
        public ApplicationUser User { get; set; } = null!;
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<MedicalRecord> MedicalRecords { get; set; } = new List<MedicalRecord>();
    }
}