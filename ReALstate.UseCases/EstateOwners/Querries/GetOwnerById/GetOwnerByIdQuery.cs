using MediatR;
using ReALstate.Domain.Entities;

namespace ReALstate.UseCases.EstateOwners.Querries.GetOwnerById
{
    public class GetOwnerByIdQuery : IRequest<EstateOwner>
    {
        public int Id {get; set;}
    }
}
