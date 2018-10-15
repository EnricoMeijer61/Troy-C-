using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Filters
{
    [DataContract]
    public class Dienst
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string dienst { get; set; }
        [DataMember]
        public string zorg { get; set; }
        [DataMember]
        public int resortid { get; set; }
    }
}