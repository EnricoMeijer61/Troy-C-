using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Entities
{
    [Table("GEBRUIKER")]
    public class Gebruiker
    {
        [Key]
        [Required]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string naam { get; set; }
        public string achternaam { get; set; }
        public DateTime geboortedatum { get; set; }
    }
}