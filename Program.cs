using System;
using System.Linq;


namespace Bus_Board
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read in the stopcode from the user 
            //Make an API call 
            //Print some stuff out 

            var transportApiClient = new TransportApiClient();

            var stopCode = GetStopCodeFromUser();

            var departures = transportApiClient.GetBusDeparturesForStop(stopCode);

            PrintNextBuses(departures);

        }

        private static void PrintNextBuses(BusDepartureResponse departures)
        {
            Console.WriteLine($"/n/nNext buses at {departures.Name}");
            foreach (var departure in departures.Departures.All.Take(5))
            {
                Console.WriteLine($"Line: {departure.Line}, To: {departure.Direction}, Levaing at: {departure.ExpectedDepartureTime}");

            }
        }

        private static string GetStopCodeFromUser()
        {
            Console.WriteLine("Please enter the bus stop code:");
            return Console.ReadLine();
        }
    }
}





            // var client = new RestClient("https://api.twitter.com/1.1");

            // var request = new RestRequest("statuses/home_timeline.json", DataFormat.Json);

            // var timeline = await client.GetAsync<ApiResponse>(request, cancellationToken);
  