using RestSharp;

namespace BusBoardCsharp.src
{
    class ReachTfl
    {
        public static string stopPoint = Utils.UserInput("Please enter StopPoint ID: ");
        
        public static RestClient tflStopPointClient = new RestClient
            ($"https://api.tfl.gov.uk/StopPoint/{stopPoint}/Arrivals");

        public static async  Task<Arrivals[]> GetStopPointArrivals()
        {  
            var request = new RestRequest();
            var response = await tflStopPointClient.GetAsync<Arrivals[]>(request);
            if (response == null)
            {
                throw new Exception ("Error reaching TFL API");
            }          
            return response;
        }   
    }
}
