using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UAIVeterinaria.Interfaces;

namespace UAIVeterinaria.Models
{
    public partial class Appointment: IEntity
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int PetId { get; set; }
        public Pet Pet { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }

    [MetadataType(typeof(AppointmentMetadata))]
    public partial class Appointment
    {
        public class AppointmentMetadata
        {
            [Key]
            public int Id { get; set; }
            
            [Required]
            public DateTime DateTime { get; set; }

            [ForeignKey("Pet")]
            [Required]
            public int PetId { get; set; }

            [ForeignKey("Doctor")]
            [Required]
            public int DoctorId { get; set; }

            [ForeignKey("Room")]
            [Required]
            public int RoomId { get; set; }
        }
    }
}