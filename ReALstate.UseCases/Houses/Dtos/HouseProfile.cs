using AutoMapper;
using ReALstate.Domain.Entities;
using ReALstate.UseCases.Houses.Commands.CreateHouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReALstate.UseCases.Houses.Dtos
{
    internal class HouseProfile : Profile
    {
        public HouseProfile()
        {
            CreateMap<CreateHouseCommand, House>()
                .ForMember(a => a.Address, opt => opt.MapFrom(src => new Address
                {
                    City = src.City,
                    Voivodeship = src.Voivodeship,
                    Street = src.Street,
                    PostalCode = src.PostalCode,
                    Number = src.Number,
                    ApartmentNumber = src.ApartmentNumber
                }));

            CreateMap<House, HouseDto>()
                .ForMember(dto => dto.City, opt => opt.MapFrom(a => a.Address.City))
                .ForMember(dto => dto.Voivodeship, opt => opt.MapFrom(a => a.Address.Voivodeship))
                .ForMember(dto => dto.Street, opt => opt.MapFrom(a => a.Address.Street))
                .ForMember(dto => dto.PostalCode, opt => opt.MapFrom(a => a.Address.PostalCode))
                .ForMember(dto => dto.Number, opt => opt.MapFrom(a => a.Address.Number))
                .ForMember(dto => dto.ApartmentNumber, opt => opt.MapFrom(a => a.Address.ApartmentNumber));
        }
    }
}
