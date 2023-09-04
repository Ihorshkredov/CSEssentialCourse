using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
   

    internal class Airport
    {
        
        List<Flight> airportDB = null;

        public Airport()
        {  
            airportDB = GetFlightDB();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Connecting to AIRport Data Base . . .");
            Console.ResetColor();

        }


        //Method for randomly generate Flight Data Base
        public List<Flight> GetFlightDB()
        {
            Random random = new Random();

            var airportDB = new List<Flight>();
            for (int i = 0; i < 50; i++)
            {
                var departure = (CityName)random.Next(1,10);
                var destination = (CityName)random.Next(1, 10);
                string flightnumber = ((FlightCode)random.Next(1, 10)).ToString() + (random.Next(1000,3000)).ToString();
                DateTime dateTime = DateTime.Now.AddDays(random.Next(1,30));

                airportDB.Add(new Flight(destination, departure, flightnumber, dateTime));
            }
              return airportDB;   
        }

        //Method for find flight information from Airport
        public List<Flight> GetFlightInfo( string city)
        {
            var result = new List<Flight>();

            if (Enum.TryParse<CityName>(city,true,out CityName destination))
            {
 
                foreach (var item in airportDB)
                {
                    if (item.Destination == destination)
                    {
                        result.Add(item);
                    }
                }    
            }
              return result;        
        }

       

    }
}
