using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Entities
{
    [Table("ACCOMODATIE")]
    public class Accomodatie
    {
        [Key]
        [Required]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string oppervlakte { get; set; }
        public int slaapkamers { get; set; }
        public int autos { get; set; }
        public int typeid { get; set; }
    }
}