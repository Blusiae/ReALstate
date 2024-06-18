namespace ReALstate.Domain.Entities
{
    // The House class is responsible for defining the attributes of a house. It inherits from the Estate class.
    public class House : Estate
    {
        public bool HasGarage { get; set; }
        public bool HasGarden { get; set; }
        public bool HasPool { get; set; }
        public bool HasTerrace { get; set; }
        public bool HasBasement { get; set; }
        public bool HasAttic { get; set; }
        public double LandInSquaredMeters { get; set; }
    }
}
