using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.EstateOwners.Querries.GetOwnerById
{
    internal class GetOwnerByIdQueryHandler
        (IEstateOwnerRepository repository, IMapper mapper) : IRequestHandler<GetOwnerByIdQuery, EstateOwner>
    {
        public async Task<EstateOwner> Handle(GetOwnerByIdQuery request, CancellationToken cancellationToken)
        {
            var owner = await repository.GetByIdAsync(request.Id);
            
            return owner;
        }
    }
}
