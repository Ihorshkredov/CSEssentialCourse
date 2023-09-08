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
            Console.WriteLine("Thanks for your choise. Our company can propose to you next flights:");
            Console.ForegroundColor= ConsoleColor.Green;

            foreach (Flight flight in data) 
            {
                Console.WriteLine(new string('-',50));
                Console.WriteLine($"Flight Number: {flight.Number} , from:\'{flight.Start}\', to:\'{flight.Destination}\'. Departure date - \'{flight.FlightDate}\'");
                Console.WriteLine(new string('-',50));
            }
            Console.ResetColor();
            
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
            foreach (var item in flightList)
            {
                if (item.Number == flightNumber)
                {
                    Console.WriteLine(new string('-',50));
                    Console.WriteLine($"You have been registered to the flight number {flightNumber}");
                    Console.WriteLine($"Your flight from {item.Start} to {item.Destination}" +
                        $" has departure date on: {item.FlightDate}" );
                    Console.WriteLine("Thank you for chosing our company");
                    Console.WriteLine("Good bye...");

                }

            }
        }

        public static void DisplayIntro(string clientName)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Airport service...");
            Console.Write($"Dear {clientName}, please enter city of your destination ->");
            Console.ResetColor();
        }

        public static string GetClientInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-',50));
            Console.Write("Hello. Please enter your full name:");
            string clientName = Console.ReadLine();
            Console.WriteLine($"Hello {clientName}. We glad that you want to use our company service to take a fligt ");
            Console.WriteLine(new string('-', 50));
            Console.ResetColor();
            return clientName;
        }

        public static bool ProposeRegistration(string clientName)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(new string('-', 50));
            Console.Write($"Dear {clientName}, would you like to register for some flight? Y / N :");
            string choise = Console.ReadLine();
            return (choise == "Y") ? true : false ;
    
        }

        public static void DisplayNoRegistrationMessage()
        {
            Console.WriteLine("Thank you for your choise. Hope you will return to us later. Good bye.");
        }
    }
}
