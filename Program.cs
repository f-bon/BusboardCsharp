namespace BusBoardCsharp
{
    class BusBoardCsharp
    {

        public static async Task Main()
        {
            var arrivalsInfo = await ReachTfl.GetStopPointArrivals();

            var arrivalsSorted = arrivalsInfo.OrderBy(i => i.TimeToStation).ToArray();
            Array.Resize(ref arrivalsSorted, 5);

            foreach (var arrival in arrivalsSorted)
            {
                Console.WriteLine($"Next bus is: {arrival.LineId}");
                Console.WriteLine($"Route: {arrival.Towards}");
                Console.WriteLine($"Destination: {arrival.DestinationName}");
                Console.WriteLine($"Arriving in: {arrival.TimeToStation/60} mins");
            } 
        }
    }
}