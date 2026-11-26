using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class MedicalRecord
    {
        [Key]
        public int MedicalRecordId { get; set; }

        // Foreign Keys
        public int PatientId { get; set; }
        public int? ParentRecordId { get; set; } // Nullable لأن أول كشف ملوش Parent
        public int AppointmentId { get; set; }

        [MaxLength(10)]
        public string? BloodType { get; set; }

        public string? Allergies { get; set; }

        public string? ChronicConditions { get; set; }

        public string? Diagnosis { get; set; }

        public string? Symptoms { get; set; }

        public string? Notes { get; set; }

        public DateTime RecordedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public Patient Patient { get; set; } = null!;
        public Appointment Appointment { get; set; } = null!;
        public MedicalRecord? ParentRecord { get; set; }
        public ICollection<MedicalRecord> FollowUpRecords { get; set; } = new List<MedicalRecord>();
        public ICollection<TreatmentPlan> TreatmentPlans { get; set; } = new List<TreatmentPlan>();
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}