
namespace Airport
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            while (true)
            {
                string clientName = Printer.GetClientInfo();
            
            
                Airport myAirport= new Airport();

        
                Printer.DisplayIntro(clientName);
                string destination = Console.ReadLine();

           
                var searchResult = myAirport.GetFlightInfo(destination);

                if (searchResult.Count>0)
                {
                    Printer.DiasplayData(searchResult);
                    bool registrationChoise = Printer.ProposeRegistration(clientName);
                    if (registrationChoise)
                    {
                        Printer.DisplayRegistrationMessage(searchResult);
                    }
                    else
                    {
                        Printer.DisplayNoRegistrationMessage();
                    } 
                }
                else
                {
                Printer.DisplayMessageNoFlight(destination);
                } 

                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}