using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UAIVeterinaria.Interfaces;

namespace UAIVeterinaria.Models
{
    public partial class Pet: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }

    [MetadataType(typeof(PetMetadata))]
    public partial class Pet
    {
        public class PetMetadata
        {
            [Key]
            public int Id { get; set; }

            [StringLength(50)]
            [Required]
            public string Name { get; set; }

            [Required]
            [ForeignKey("Owner")]
            public int OwnerId { get; set; }
        }
    }
}