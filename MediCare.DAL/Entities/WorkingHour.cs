using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class WorkingHour
    {
        [Key]
        public int WorkingHourId { get; set; }

        // Foreign Key
        public int DoctorId { get; set; }

        [Required, MaxLength(20)]
        public string DayOfWeek { get; set; } = string.Empty;

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        public int SlotDurationMinutes { get; set; }

        // Navigation Property
        public Doctor Doctor { get; set; } = null!;
    }
}