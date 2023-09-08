
namespace Airport
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //Get information about client:
            string clientName = Printer.GetClientInfo();
            
            //Generating Airport DB
            Airport myAirport= new Airport();

            //Display message for get destination
            Printer.DisplayIntro(clientName);
            string destination = Console.ReadLine();

            //Making search in Airport Pseudo DB
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
        }
    }
}