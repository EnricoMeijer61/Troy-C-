using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend.Models
{
    public class PrijsModel
    {
        public int id { get; set; }
        public int prijs { get; set; }
        public int accomodatieid { get; set; }
        public int dienstid { get; set; }
    }
}