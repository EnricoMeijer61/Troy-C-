using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend.Models
{
    public class ReservatieModel
    {
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