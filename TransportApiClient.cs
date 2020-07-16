using RestSharp;

namespace Bus_Board
{
    public class TransportApiClient
    //thing that is going to make our api call and return our objects, going to fetch our data
    {
        private RestClient client;
        //private field that noo one else can see but we can keep track of, this is the rest client.


        //make a contructor, when you create a new one of these classes, the first thing it does is
        //it goes and creates a new client (line below)
        public TransportApiClient()
        {
            client = new RestClient("https://transportapi.com/");
            //URL going to the URL which loads all the objects on the page
        
        }
        //every instance of this class builds its own client for itself and the client
        //is going to be centred on this URL 

        public BusDepartureResponse GetBusDeparturesForStop(string stopcode)
        //make a method which makes this call for us. It's going to return the object we just created
        // going to return a bus departure response and going to call it GetBusDepartureForStop
        //if you give me a stop code, i'll give you back the buses for that bus stop.
        {
            var request = new RestRequest("v3/uk/bus/stop/490008660N/live.json")
                .AddUrlSegment("stopcode", stopcode)
                .AddQueryParameter("app_id", "3d4e7caf")
                .AddQueryParameter("app_key", "d6e85b063f40ecaa367a39324004c466")
                .AddQueryParameter("group", "no")
                .AddQueryParameter("nextbuses", "yes");

            var response = client.Get<BusDepartureResponse>(request);

        //these are just the lines from our instructions. We can make our new rest request
        // the path for this is v3/uk/bus/stop/490008660N/live.json
        //we've also got query parameters which is the rest of it, which are broken down into several parameters
        // each parameter takes a name and a value ("name", "value")
            return response.Data;
        }
    }
}