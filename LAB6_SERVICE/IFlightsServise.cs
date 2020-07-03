using LAB6_SERVICE.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB6_SERVICE
{
    public interface IFlightsServise
    {
        List<Flight> getAllFlights();
        void addFlight(Flight flight);
        Flight getFreeFlight();
        Flight getFlightAt(int index);
        Ticket buyTicket(Person person);

    }
}