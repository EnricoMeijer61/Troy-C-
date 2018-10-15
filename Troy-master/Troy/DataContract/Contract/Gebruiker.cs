using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Contract
{
    [DataContract]
    public class Gebruiker
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string naam { get; set; }
        [DataMember]
        public string achternaam { get; set; }
        [DataMember]
        public DateTime geboortedatum { get; set; }
    }
}