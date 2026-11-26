using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class TreatmentPlan
    {
        [Key]
        public int TreatmentPlanId { get; set; }

        // Foreign Keys
        public int MedicalRecordId { get; set; }
        public int DoctorId { get; set; }

        [Required]
        public string PlanDescription { get; set; } = string.Empty;

        public DateOnly StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; } = "Active";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation Properties
        public MedicalRecord MedicalRecord { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
    }
}