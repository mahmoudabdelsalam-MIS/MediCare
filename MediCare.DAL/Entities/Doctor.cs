using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediCare.DAL.Entities
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        // Foreign Keys
        public int UserId { get; set; }
        public int SpecializationId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ConsultationFee { get; set; }

        public int YearsOfExperience { get; set; }

        public bool IsActive { get; set; } = true;

        // Navigation Properties
        public ApplicationUser User { get; set; } = null!;
        public Specialization Specialization { get; set; } = null!;
        public ICollection<WorkingHour> WorkingHours { get; set; } = new List<WorkingHour>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
        public ICollection<TreatmentPlan> TreatmentPlans { get; set; } = new List<TreatmentPlan>();
        public ICollection<Prescription> Prescriptions { get; set; } = new List<Prescription>();
    }
}