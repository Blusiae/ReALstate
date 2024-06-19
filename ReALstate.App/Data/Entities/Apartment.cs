namespace ReALstate.App.Data.Entities
{
    public class Apartment : Estate 
    { 
        public int Floor { get; set; }
        public bool IsElevatorAvailable { get; set; }
        public bool HasPrivateParkingSpace { get; set; }
    }
}
