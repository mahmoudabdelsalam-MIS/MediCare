using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class Prescription
    {
        [Key]
        public int PrescriptionId { get; set; }

        // Foreign Keys
        public int MedicalRecordId { get; set; }
        public int DoctorId { get; set; }

        public DateOnly PrescriptionDate { get; set; }

        [Required]
        public string MedicationsJson { get; set; } = string.Empty;

        public string? Notes { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; } = "Active";

        // Navigation Properties
        public MedicalRecord MedicalRecord { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
    }
}