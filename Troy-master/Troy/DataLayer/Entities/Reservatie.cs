using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataLayer.Entities
{
    [Table("RESERVATIE")]
    public class Reservatie
    {
        [Key]
        [Required]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public DateTime datum { get; set; }
        public DateTime start { get; set; }
        public DateTime eind { get; set; }
        public int gebruikerid { get; set; }
        public int resortid { get; set; }
        public int accomodatieid { get; set; }
        public int dienstid { get; set; }
    }
}