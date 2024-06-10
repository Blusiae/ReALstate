using AutoMapper;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.Apartments.Commands.CreateApartment;

namespace ReALstate.UseCases.Apartments.Dtos
{
    internal class ApartmentProfile : Profile
    {
        public ApartmentProfile()
        {
            CreateMap<CreateApartmentCommand, Apartment>()
                .ForMember(a => a.Address, opt => opt.MapFrom(src => new Address
                {
                    City = src.City,
                    Voivodeship = src.Voivodeship,
                    Street = src.Street,
                    PostalCode = src.PostalCode,
                    Number = src.Number,
                    ApartmentNumber = src.ApartmentNumber
                }));
        }
    }
}
