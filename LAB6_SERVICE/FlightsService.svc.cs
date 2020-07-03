using LAB6_SERVICE.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LAB6_SERVICE
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "FlightsService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы FlightsService.svc или FlightsService.svc.cs в обозревателе решений и начните отладку.
    public class FlightsService : IFlightsServise
    {
        static int ticketId = 0;

        public void addFlight(Flight flight)
        {
            FlightsData.Flights.Add(flight);
        }

        public Ticket buyTicket(Person person, string arrivalAddress, string departureAddress, string departureTime)
        {
            
            Ticket newTicket = new Ticket();
            newTicket.Person = person;
            newTicket.Id = ticketId.ToString();

            ticketId++;

            Flight f = FlightsData.Flights.SingleOrDefault(e => (e.ArrivalAddress == arrivalAddress && e.DepartureAddress == departureAddress && e.DepartureTime == departureTime));

            if (f != null)
            {
                newTicket.Flight = f;
                f.AvailableTicketsCount--;
                FlightsData.Tickets.Add(newTicket);
                return newTicket;
            }
            return null;
        }

        public List<Flight> getAllFlights()
        {
            return FlightsData.Flights;
        }

        public Flight getFlightAt(int index)
        {
            return FlightsData.Flights[index];
        }

        public Flight getFreeFlight()
        {
            foreach(Flight f in FlightsData.Flights)
            {
                if (f.AvailableTicketsCount  >= 1)
                {
                    return f;
                }
            }
            return null;
        }
    }
}
