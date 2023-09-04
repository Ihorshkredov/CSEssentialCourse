
namespace Airport
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            
            Airport myAirport= new Airport();
            Printer.DisplayIntro();

            string destination = Console.ReadLine();

            //Making search in Airport Pseudo DB
            var searchResult = myAirport.GetFlightInfo(destination);

            if (searchResult.Count>0)
            {
                Printer.DiasplayData(searchResult);
                
            }
            else
            {
                Printer.DisplayMessageNoFlight(destination);
            }
         
        }
    }
}