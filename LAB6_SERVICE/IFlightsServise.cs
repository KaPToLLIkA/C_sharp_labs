using LAB6_SERVICE.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace LAB6_SERVICE
{
    [ServiceContract]
    public interface IFlightsServise
    {
        [OperationContract]
        List<Flight> getAllFlights();
        
        [OperationContract]
        void addFlight(Flight flight);
        
        [OperationContract]
        Flight getFreeFlight();
        
        [OperationContract]
        Flight getFlightAt(int index);
        
        [OperationContract]
        Ticket buyTicket(Person person);

    }
}