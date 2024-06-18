namespace ReALstate.Domain.Entities
{
    // The Apartment class is responsible for defining the attributes of an apartment. It inherits from the Estate class.
    public class Apartment : Estate
    {
        public int Floor { get; set; }
        public bool IsElevatorAvailable { get; set; }
        public bool HasPrivateParkingSpace { get; set; }
    }
}
