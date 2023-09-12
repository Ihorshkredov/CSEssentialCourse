using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
   

    internal class Airport
    {
        private readonly List<Flight> flightList;

        public Airport()
        {  
            flightList = GetListOfFlights();
        }

        public List<Flight> GetFlightInfo(string city)
        {
            List<Flight> result = new List<Flight>();

            if (Enum.TryParse(city,true,out CityName destination))
            {
                var query = from flight in flightList
                            where flight.Destination == destination
                            orderby flight.FlightDate
                            select flight;

               result.AddRange(query);
            }

            return result;        
        }

        private List<Flight> GetListOfFlights()
        {
            Random random = new Random();

            var flightList = new List<Flight>();
            for (int i = 0; i < 50; i++)
            {
                var departure = (CityName)random.Next(0, 9);
                var destination = (CityName)random.Next(0, 9);
                string flightnumber = ((FlightCode)random.Next(0, 9)).ToString()
                                                + (random.Next(1000, 3000)).ToString();
                DateTime dateTime = DateTime.Now.AddDays(random.Next(1, 30));

                flightList.Add(new Flight(destination, departure, flightnumber, dateTime));
            }

            return flightList;
        }
    }
}
