using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcEFApp.Models
{
    public class Appointment
    {
        [Key]
        [Column("appointment")]
        public int Id { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        public int DoctorId { get; set;}
        [Required]
        public DateTime DateOfAppointment { get; set; }
        [Required]
        public bool Status { get; set; }    
    }
}
