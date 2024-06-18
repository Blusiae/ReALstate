using MediatR;
using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.Apartments.Commands.CreateApartment
{
    // CreateApartmentCommand is a class that will be used to create a new apartment.
    // It will be used in the CreateApartmentHandler class. It inherits from IRequest<int> interface, implementing CQRS pattern. <int> is the return type of the Handle method.
    public class CreateApartmentCommand : IRequest<int>
    {
        public string Description { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public double MetersSquared { get; set; }
        public double Value { get; set; }
        public State State { get; set; } = default!;
        public string City { get; set; } = default!;
        public string Voivodeship { get; set; } = default!;
        public string Street { get; set; } = default!;
        public string PostalCode { get; set; } = default!;
        public string Number { get; set; } = default!;
        public string ApartmentNumber { get; set; } = default!;
        public int OwnerId { get; set; }
        public DateTime? YearBuilt { get; set; }

        //Additional information
        public int BedroomsCount { get; set; }
        public int BathroomsCount { get; set; }
        public bool IsFurnushed { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasAirConditioning { get; set; }
        public bool HasHeating { get; set; }
        public int Floor { get; set; }
        public bool IsElevatorAvailable { get; set; }
        public bool HasPrivateParkingSpace { get; set; }
    }
}
