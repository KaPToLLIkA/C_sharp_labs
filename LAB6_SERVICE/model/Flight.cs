using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LAB6_SERVICE.model
{
    [DataContract]
    public class Flight
    {

        [DataMember]
        public int AvailableTicketsCount
        {
            get; set;
        }


        [DataMember]
        public string DepartureAddress
        {
            get;set;
        }


        [DataMember]
        public string ArrivalAddress
        {
            get;set;
        }

        [DataMember]
        public string DepartureTime
        {
            get;set;
        }


        [DataMember]
        public string ArrivalTime
        {
            get;set;
        }

    }
}