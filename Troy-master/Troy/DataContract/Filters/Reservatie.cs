using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Filters
{
    [DataContract]
    public class Reservatie
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public DateTime datum { get; set; }
        [DataMember]
        public DateTime start { get; set; }
        [DataMember]
        public DateTime eind { get; set; }
        [DataMember]
        public int gebruikerid { get; set; }
        [DataMember]
        public int resortid { get; set; }
        [DataMember]
        public int accomodatieid { get; set; }
        [DataMember]
        public int dienstid { get; set; }
    }
}