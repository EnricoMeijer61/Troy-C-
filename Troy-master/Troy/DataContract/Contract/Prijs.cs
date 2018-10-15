using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Contract
{
    [DataContract]
    public class Prijs
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int prijs { get; set; }
        [DataMember]
        public int accomodatieid { get; set; }
        [DataMember]
        public int dienstid { get; set; }
    }
}