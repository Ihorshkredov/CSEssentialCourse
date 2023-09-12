using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public static class Printer
    {
        public static void DiasplayData(List<Flight> data)
        {
            
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("Thanks for your choise. Our company can propose to you next flights:\n");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(new string('-',100));
            Console.WriteLine("Flight Number |  Departure Date    |  Departure Time     |    From          |      Destination      |");
            Console.WriteLine(new string('-', 100));

            foreach (Flight flight in data) 
            {
                PrintFlightData(flight);      
            }
            Console.ResetColor();
            
        }

        public static void PrintFlightData(Flight flight)
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(flight);
            Console.WriteLine(new string('-', 100));
        }

        public static void DisplayMessageNoFlight(string destination)
        {
            Console.WriteLine($"There is no flight to the city: {destination}");
            Console.WriteLine("Our company has connection only between:");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine((CityName)i);

            }

        }

        public static void DisplayRegistrationMessage(List<Flight> flightList)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Please enter the Number of the Flight which you want to go: ");
            string flightNumber = Console.ReadLine();

            var mathedFlights = flightList.Where(flight => flight.Number == flightNumber);

            if (mathedFlights.Any())
            {
                foreach (var item in mathedFlights)
                {
                    Console.WriteLine(new string('-', 100));
                    Console.WriteLine($"You have been registered to the flight number {flightNumber}");
                    Console.WriteLine($"Your flight from {item.Start} to {item.Destination}" +
                        $" has departure date on: {item.FlightDate}");
                    Console.WriteLine("Thank you for chosing our company");
                    Console.WriteLine("Good bye...");

                }
            }
            else
            {
                Console.WriteLine("Incorrect flight number. Try again");
            }
        }

        public static void DisplayIntro(string clientName)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Welcome to Flight Menu.");
            Console.Write($"Dear {clientName}, please enter city of your destination ->");
            Console.ResetColor();
        }

        public static string GetClientInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-',100));
            Console.Write("Hello. Please enter your full name:");

            string clientName = Console.ReadLine();

            Console.WriteLine($"Hello {clientName}. We glad that you want to use our company service to take a fligt ");
            Console.WriteLine(new string('-', 100));
            Console.ResetColor();
            
            return clientName;
        }

        public static bool ProposeRegistration(string clientName)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-', 100));
            Console.Write($"Dear {clientName}, would you like to register for some flight? Y / N :");
            string choise = Console.ReadLine();
            
            return (choise == "Y");
    
        }

        public static void DisplayNoRegistrationMessage()
        {
            Console.WriteLine("Thank you for your choise. Hope you will return to us later. Good bye.");
        }
    }
}
