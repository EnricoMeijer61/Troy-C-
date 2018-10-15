using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DataContract.Filters
{
    [DataContract]
    public class AccomodatieFaciliteit
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string faciliteit { get; set; }
        [DataMember]
        public int accomodatieid { get; set; }
    }
}