using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Filters
{
    [DataContract]
    public class Type
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public int type { get; set; }
        [DataMember]
        public string bio { get; set; }
        [DataMember]
        public int resortid { get; set; }
    }
}