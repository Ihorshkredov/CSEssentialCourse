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
            Console.ForegroundColor= ConsoleColor.Green;

            foreach (Flight flight in data) 
            {
                Console.WriteLine(new string('-',50));
                Console.WriteLine($"Flight Number: {flight.Number} , from:\'{flight.Start}\', to:\'{flight.Destination}\'. Departure date - \'{flight.FlightDate}\'");
                Console.WriteLine(new string('-',50));
            }
            Console.ForegroundColor= ConsoleColor.White;
            
        }

        public static void DisplayMessageNoFlight(string destination)
        {
            Console.WriteLine($"There is no flight to the city: {destination}");
            Console.WriteLine("Our company has connection only between:");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine((Cities)i);

            }

        }

        public static void DisplayRegistrationMessage()
        {
            Console.WriteLine("Please enter the Number of the Flight which you want to go: ");
        }

        public static void DisplayIntro()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Airport service...");
            Console.Write("Please enter city of your destination ->");
            Console.ResetColor();
        }
    }
}
