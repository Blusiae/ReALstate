using AutoMapper;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.EstateOwners.Commands.CreateOwner;

namespace ReALstate.UseCases.EstateOwners.Dtos
{
    internal class EstateOwnerProfile : Profile
    {
        public EstateOwnerProfile()
        {
            CreateMap<CreateOwnerCommand, EstateOwner>();
        }
    }
}
