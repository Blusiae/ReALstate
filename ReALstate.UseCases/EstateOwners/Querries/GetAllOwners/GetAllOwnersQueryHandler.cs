using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.EstateOwners.Querries.GetAllOwners
{
    internal class GetAllOwnersQueryHandler
        (IEstateOwnerRepository repository, IMapper mapper) : IRequestHandler<GetAllOwnersQuery, IEnumerable<EstateOwner>>
    {
        public async Task<IEnumerable<EstateOwner>> Handle(GetAllOwnersQuery request, CancellationToken cancellationToken)
        {
            var owners = await repository.GetAllAsync();
            return owners;
        }
    }
}
