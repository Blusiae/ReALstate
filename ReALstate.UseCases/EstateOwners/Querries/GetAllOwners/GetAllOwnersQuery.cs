using MediatR;
using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.EstateOwners.Querries.GetAllOwners
{
    public class GetAllOwnersQuery : IRequest<IEnumerable<EstateOwner>>
    {
    }
}
