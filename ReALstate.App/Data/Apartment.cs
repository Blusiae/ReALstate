namespace ReALstate.App.Data
{
    internal class Apartment : Estate
    {
        internal int Floor { get; set; }
        internal bool IsElevatorAvailable { get; set; }
        internal bool HasPrivateParkingSpace { get; set; }
    }
}
