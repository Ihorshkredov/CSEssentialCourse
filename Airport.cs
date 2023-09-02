using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public enum Cities
    { 
        Berlin = 1,
        Kiev,
        Paris,
        London,
        Helsinki,
        Budapest,
        Istambul,
        Riga,
        Vien,
        Lissabon

    }

    public enum FlightCode
    {
        AY,
        BU,
        HA,
        KO,
        WS,
        RP,
        OV,
        MN,
        QA,
        IL
    }

    internal class Airport
    {
        Random random = new Random();
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
            var airportDB = new List<Flight>();
            for (int i = 0; i < 50; i++)
            {
                var departure = (Cities)random.Next(1,10);
                var destination = (Cities)random.Next(1, 10);
                string flightnumber = ((FlightCode)random.Next(1, 10)).ToString()+(random.Next(1000,3000)).ToString();
                DateTime dateTime = DateTime.Now.AddDays(random.Next(1,30));

                airportDB.Add(new Flight(destination, departure, flightnumber, dateTime));
            }
            return airportDB;   
        }

        //Method for find flight information from Airport
        public List<Flight> GetFlightInfo( string city)
        {
            var result = new List<Flight>();

            if (Enum.TryParse<Cities>(city,true,out Cities destination))
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
