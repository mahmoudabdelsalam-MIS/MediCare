using System.ComponentModel.DataAnnotations;

namespace MediCare.DAL.Entities
{
    public class QueueTicket
    {
        [Key]
        public int TicketId { get; set; }

        // Foreign Key (1:1)
        public int AppointmentId { get; set; }

        public int QueueNumber { get; set; }

        [Required, MaxLength(50)]
        public string Status { get; set; } = "Waiting";

        public DateTime CheckInTime { get; set; } = DateTime.Now;

        public DateTime? CompletedAt { get; set; }

        // Navigation Property
        public Appointment Appointment { get; set; } = null!;
    }
}