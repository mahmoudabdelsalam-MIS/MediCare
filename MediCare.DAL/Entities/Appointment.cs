using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        // Foreign Keys
        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public DateOnly AppointmentDate { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; } = "Scheduled";

        // Navigation Properties
        public Patient Patient { get; set; } = null!;
        public Doctor Doctor { get; set; } = null!;
        public QueueTicket? QueueTicket { get; set; }
        public MedicalRecord? MedicalRecord { get; set; }
    }
}