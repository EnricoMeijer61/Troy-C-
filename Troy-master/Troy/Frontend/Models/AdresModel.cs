using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Frontend.Models
{
    public class AdresModel
    {
        [Required]
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