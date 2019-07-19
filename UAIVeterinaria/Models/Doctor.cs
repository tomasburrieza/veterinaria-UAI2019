using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using UAIVeterinaria.Interfaces;

namespace UAIVeterinaria.Models
{
    public partial class Doctor : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DNI { get; set; }
        public string Matricula { get; set; }
    }

    [MetadataType(typeof(DoctorMetadata))]
    public partial class Doctor
    {
        public class DoctorMetadata
        {
            [Key]
            public int Id { get; set; }

            [StringLength(50)]
            [Required]
            public string Name { get; set; }

            [StringLength(50)]
            [Required]
            public string Surname { get; set; }

            [StringLength(50)]
            [Required]
            public string DNI { get; set; }

            [StringLength(50)]
            [Required]
            public string Matricula { get; set; }
        }
    }
}