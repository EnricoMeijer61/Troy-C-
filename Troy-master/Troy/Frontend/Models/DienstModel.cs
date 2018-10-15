using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Frontend.Models
{
    public class DienstModel
    {
        public int id { get; set; }
        public string dienst { get; set; }
        public string zorg { get; set; }
        public int resortid { get; set; }
    }
}