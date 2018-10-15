using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Entities
{
    [Table("ADRES")]
    public class Adres
    {
        [Key]
        [Required]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string land { get; set; }
        public string stad { get; set; }
        public string provincie { get; set; }
        public string straat { get; set; }
        public string postcode { get; set; }
        public int telefoonnummer { get; set; }
        public string email { get; set; }
        public int gebruikerid { get; set; }
        public int resortid { get; set; }
    }
}