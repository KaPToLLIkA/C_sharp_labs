using LAB6_SERVICE.model;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace LAB6_SERVICE
{
    
    
    public static class FlightsData
    {
        private static List<Flight> _flights = new List<Flight>();
        private static List<Ticket> _tickets = new List<Ticket>();

        public static List<Flight> Flights
        {
            get { return _flights; }
        }

        public static List<Ticket> Tickets
        {
            get { return _tickets; }
        }
    }
}
