using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LAB6_SERVICE.model
{
    [DataContract]
    public class Person
    {

        [DataMember]
        public string FIO
        {
            get; set;
        }


        [DataMember]
        public int id
        {
            get; set;
        }
    }
}