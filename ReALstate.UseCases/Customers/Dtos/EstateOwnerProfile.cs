using AutoMapper;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.Customers.Commands.CreateCustomer;

namespace ReALstate.UseCases.Customers.Dtos
{
    internal class EstateOwnerProfile : Profile
    {
        public EstateOwnerProfile()
        {
            CreateMap<CreateCustomerCommand, Customer>();
        }
    }
}
