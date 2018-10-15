using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Contract
{
    [DataContract]
    public class Uuid
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string uniqueidentifier { get; set; }
        [DataMember]
        public int gebruikerid { get; set; }
    }
}