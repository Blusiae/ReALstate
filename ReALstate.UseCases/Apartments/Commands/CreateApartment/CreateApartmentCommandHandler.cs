using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Apartments.Commands.CreateApartment
{
    // CreateApartmentCommandHandler is a class that will be used to handle the CreateApartmentCommand.
    // It inherits from IRequestHandler<CreateApartmentCommand, int> interface, implementing CQRS pattern.
    public class CreateApartmentCommandHandler
        (ICustomerRepository customerRepository,
        IApartmentRepository apartmentRepository,
        IMapper mapper) : IRequestHandler<CreateApartmentCommand, int>
    {
        // The Handle method is used to handle the CreateApartmentCommand. It creates a new apartment and returns its id.
        public async Task<int> Handle(CreateApartmentCommand request, CancellationToken cancellationToken)
        {
            var owner = await customerRepository.GetByIdAsync(request.OwnerId);

            if (owner == null)
            {
                throw new NotFoundException(nameof(Customer) + "(owner)", request.OwnerId.ToString());
            }
            var apartment = mapper.Map<Apartment>(request);
            
            apartment.Owner = owner;

            var id = await apartmentRepository.Create(apartment);

            return id;
        }
    }
}
