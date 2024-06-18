using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Houses.Commands.CreateHouse
{
    // This class is responsible for handling the CreateHouseCommand
    internal class CreateHouseCommandHandler
        (IHouseRepository repository,
        ICustomerRepository customerRepository,
        IMapper mapper): IRequestHandler<CreateHouseCommand, int>
    {
        // This method is responsible for creating a new house
        public async Task<int> Handle(CreateHouseCommand request, CancellationToken cancellationToken)
        {
            var owner = await customerRepository.GetByIdAsync(request.OwnerId);
            
            if (owner == null)
            {
                throw new NotFoundException(nameof(Customer) + "(owner)", request.OwnerId.ToString());

            }
            
            var house = mapper.Map<House>(request);
            
            house.Owner = owner;
            
            await repository.Create(house);
            
            return house.Id;
        }
    }
}
