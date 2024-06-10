using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Apartments.Commands.CreateApartment
{
    public class CreateApartmentCommandHandler
        (ICustomerRepository customerRepository,
        IApartmentRepository apartmentRepository,
        IMapper mapper) : IRequestHandler<CreateApartmentCommand, int>
    {
        public async Task<int> Handle(CreateApartmentCommand request, CancellationToken cancellationToken)
        {
            var owner = await customerRepository.GetByIdAsync(request.OwnerId);

            if (owner == null)
            {
                throw new Exception("Owner not found");
            }
            var apartment = mapper.Map<Apartment>(request);
            
            apartment.Owner = owner;

            var id = await apartmentRepository.Create(apartment);

            return id;
        }
    }
}
