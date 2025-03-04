using RestSharp;

namespace BusBoardCsharp.src
{
    class TflClient
    {
        public static RestClient tflStopPointClient = new RestClient
            ($"https://api.tfl.gov.uk/StopPoint/");

        public static async  Task<Arrivals[]> GetStopPointArrivals(string stopPoint)
        {  
            var request = new RestRequest($"{stopPoint}/Arrivals");
            var response = await tflStopPointClient.GetAsync<Arrivals[]>(request);
            if (response == null)
            {
                throw new Exception ("Error reaching TFL API");
            }          
            return response;
        }   
    }
}
