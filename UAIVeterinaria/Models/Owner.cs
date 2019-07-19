using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UAIVeterinaria.Interfaces;

namespace UAIVeterinaria.Models
{
    public partial class Owner : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }

    [MetadataType(typeof(OwnerMetadata))]
    public partial class Owner
    {
        public class OwnerMetadata
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
            public string Address { get; set; }
        }
    }
}