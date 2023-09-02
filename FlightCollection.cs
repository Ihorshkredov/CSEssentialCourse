using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    internal class FlightCollection : IEnumerable, IEnumerator
    {
        private readonly Flight [ ] myFlightCollection;
        private int i;

        public FlightCollection()
        {
            myFlightCollection= new Flight[50];
            i = -1;
        }
            

        public object Current => myFlightCollection [i];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (i < myFlightCollection.Length-1)
            {
                i++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            i = -1;
        }
    }
}
