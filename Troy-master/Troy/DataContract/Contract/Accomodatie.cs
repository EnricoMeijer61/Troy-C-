using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Contract
{
    [DataContract]
    public class Accomodatie
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string oppervlakte { get; set; }
        [DataMember]
        public int slaapkamers { get; set; }
        [DataMember]
        public int autos { get; set; }
        [DataMember]
        public int typeid { get; set; }
    }
}