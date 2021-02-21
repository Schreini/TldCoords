namespace TldCoords
{
    public record Koordinaten
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }        
        public int XReal { get; init; }
        public int YReal { get; init; }
        public int ZReal { get; init; }
    }
}