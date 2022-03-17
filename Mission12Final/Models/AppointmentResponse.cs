using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission12Final.Models
{
    public class AppointmentResponse
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }

        [Required(ErrorMessage = "Group Name is missing.")]
        public string GroupName { get; set; }

        [Range(1, 15, ErrorMessage ="Group size must be from 1 - 15")]
        public int GroupSize { get; set; }

        [Required(ErrorMessage = "Email is missing.")]
        public string Email { get; set; }

        // optional
        public string Phone { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }
    }
}
