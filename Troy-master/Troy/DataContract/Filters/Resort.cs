using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Filters
{
    [DataContract]
    public class Resort
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string naam { get; set; }
        [DataMember]
        public string bio { get; set; }
    }
}