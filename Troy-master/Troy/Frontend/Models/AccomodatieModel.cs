using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend.Models
{
    public class AccomodatieModel
    {
        public int id { get; set; }
        public string oppervlakte { get; set; }
        public int slaapkamers { get; set; }
        public int autos { get; set; }
        public int typeid { get; set; }
    }
}