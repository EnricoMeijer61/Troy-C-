using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend.Models
{
    public class GebruikerModel
    {
        public int id { get; set; }
        public string naam { get; set; }
        public string achternaam { get; set; }
        public DateTime geboortedatum { get; set; }
    }
}