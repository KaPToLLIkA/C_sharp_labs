using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB6_CONSOLE_CLIENT.MyService;

namespace LAB6_CONSOLE_CLIENT
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightsServiseClient client = new FlightsServiseClient();

            while (true)
            {
                Console.WriteLine("1 Add flight\n" +
                    "2 Buy ticket\n" +
                    "3 Get all flights\n" +
                    "4 Get free flight\n" +
                    "0 EXIT\n\n\n");
                switch (Console.ReadLine())
                {
                    case "1":
                        Flight newFlight = new Flight();
                        Console.Write("Arrival address: ");
                        newFlight.ArrivalAddress = Console.ReadLine();
                        Console.Write("Departure address: ");
                        newFlight.DepartureAddress = Console.ReadLine();
                        Console.Write("Arrival time: ");
                        newFlight.ArrivalTime = Console.ReadLine();
                        Console.Write("Departure time: ");
                        newFlight.DepartureTime = Console.ReadLine();
                        newFlight.AvailableTicketsCount = 1000;

                        client.addFlight(newFlight);

                        break;
                    case "2":

                        Person p = new Person();
                        Console.Write("FIO: ");
                        p.FIO = Console.ReadLine();
                        while (true)
                        {
                            Console.Write("ID (passport): ");
                            try
                            {
                                p.id = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Error");
                            }
                        }

                        Console.Write("Arrival address: ");
                        string arrAddr = Console.ReadLine();
                        Console.Write("Departure address: ");
                        string depAddr = Console.ReadLine();
                        Console.Write("Departure time: ");
                        string depTime = Console.ReadLine();

                        Ticket t = client.buyTicket(p, arrAddr, depAddr, depTime);

                        if (t != null)
                        {
                            Console.WriteLine(showTicket(t));
                        } else
                        {
                            Console.WriteLine("Error");
                        }

                        break;
                    case "3":
                        foreach(Flight f in client.getAllFlights())
                        {
                            Console.WriteLine(showFlight(f));
                        }

                        break;

                    case "4":
                        Console.WriteLine(showFlight(client.getFreeFlight()));

                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:

                        break;
                }




            }
        }


        static string showFlight(Flight f)
        {
            return "DepAddr: " + f.DepartureAddress + "\n" +
                "ArrivAddr: " + f.ArrivalAddress + "\n" +
                "DepTime: " + f.DepartureTime + "\n" +
                "ArriveTime: " + f.ArrivalTime + "\n" +
                "Spaces: " + f.AvailableTicketsCount + "\n";
        }


        static string showPerson(Person p)
        {
            return "FIO: " + p.FIO + "\n" +
                "ID: " + p.id + "\n";
        }

        static string showTicket(Ticket t)
        {
            return "ID: " + t.Id + "\n" +
                "Person: " + showPerson(t.Person) + 
                "Flight: " + showFlight(t.Flight);
        }
    }
}
