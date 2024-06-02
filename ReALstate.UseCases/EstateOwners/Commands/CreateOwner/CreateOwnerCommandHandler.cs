using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.EstateOwners.Commands.CreateOwner
{
    internal class CreateOwnerCommandHandler
        (IEstateOwnerRepository repository, IMapper mapper) : IRequestHandler<CreateOwnerCommand, int>
    {

        async Task<int> IRequestHandler<CreateOwnerCommand, int>.Handle(CreateOwnerCommand request, CancellationToken cancellationToken)
        {
            var owner = mapper.Map<EstateOwner>(request);

            int id = await repository.Create(owner);

            return id;
        }
    }
}
