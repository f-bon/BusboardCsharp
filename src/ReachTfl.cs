using RestSharp;

namespace BusBoardCsharp
{
    class ReachTfl
    {
        public static string stopPoint = "490008660N";
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
