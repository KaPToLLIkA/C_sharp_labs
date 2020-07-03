using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LAB6_SERVICE.model
{
    [DataContract]
    public class Ticket
    {

        [DataMember]
        public string Id
        {
            get; set;
        }


        [DataMember]
        public Person Person
        {
            get; set;
        }


        [DataMember]
        public Flight Flight
        {
            get; set;
        }
    }
}