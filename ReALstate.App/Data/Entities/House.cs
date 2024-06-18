namespace ReALstate.App.Data.Entities
{
    internal class House : Estate
    {
        internal bool HasGarage { get; set; }
        internal bool HasGarden { get; set; }
        internal bool HasPool { get; set; }
        internal bool HasTerrace { get; set; }
        internal bool HasBasement { get; set; }
        internal bool HasAttic { get; set; }
        internal double LandInSquaredMeters { get; set; }
    }
}
