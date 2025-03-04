namespace BusBoardCsharp.src
{
    public class Arrivals
    {
        public required string LineId { get; set; }
        public required string Towards { get; set; }
        public required string DestinationName { get; set; }
        public required int TimeToStation { get; set; }
    }
}