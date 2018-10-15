using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Filters
{
    [DataContract]
    public class Adres
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string land { get; set; }
        [DataMember]
        public string stad { get; set; }
        [DataMember]
        public string provincie { get; set; }
        [DataMember]
        public string straat { get; set; }
        [DataMember]
        public string postcode { get; set; }
        [DataMember]
        public int telefoonnummer { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public int gebruikerid { get; set; }
        [DataMember]
        public int resortid { get; set; }
    }
}