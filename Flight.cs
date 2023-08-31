using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
   
    public class Flight
    { 

        public Cities Destination { get; }
        public Cities Start { get; }
        public string Number { get; }
        public DateTime FlightDate { get; }

        public Flight(Cities dest, Cities start, string number, DateTime flightDate)
        {
            Destination = dest;
            Start = start;
            Number = number;
            FlightDate = flightDate;

        }
    }
}
