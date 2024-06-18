using AutoMapper;

namespace ReALstate.UseCases.Offer.Dtos
{
    // OfferProfile class determines the mapping between CreateOfferCommand, OfferDto and Offer entity
    internal class OfferProfile : Profile
    {
        public OfferProfile()
        {
            // Mappings
            CreateMap<Commands.CreateOffer.CreateOfferCommand, Domain.Entities.Offer>();
            CreateMap<Domain.Entities.Offer, OfferDto>();
        }
    }
}
