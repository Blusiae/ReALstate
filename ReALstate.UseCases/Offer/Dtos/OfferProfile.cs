using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReALstate.UseCases.Offer.Dtos
{
    internal class OfferProfile : Profile
    {
        public OfferProfile()
        {
            CreateMap<Commands.CreateOffer.CreateOfferCommand, Domain.Entities.Offer>();
            CreateMap<Domain.Entities.Offer, OfferDto>();
        }
    }
}
