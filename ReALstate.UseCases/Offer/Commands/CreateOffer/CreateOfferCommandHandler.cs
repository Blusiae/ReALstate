using AutoMapper;
using MediatR;
using ReALstate.Domain.Interfaces.Repositories;

namespace ReALstate.UseCases.Offer.Commands.CreateOffer
{
    internal class CreateOfferCommandHandler
        (IOfferRepository offerRepository, 
        ICustomerRepository customerRepository, 
        IEstateRepository estateRepository, 
        IMapper mapper) : IRequestHandler<CreateOfferCommand, int>
    {
        public async Task<int> Handle(CreateOfferCommand request, CancellationToken cancellationToken)
        {


            var customer = await customerRepository.GetByIdAsync(request.CustomerId);
            var estate = await estateRepository.GetByIdAsync(request.EstateId);

            if (customer == null || estate == null)
                throw new Exception("Customer or Estate not found");

            var offer = mapper.Map<Domain.Entities.Offer>(request);

            offer.Customer = customer;
            offer.Estate = estate;
 
            int id = await offerRepository.Create(offer);

            return id;
        }
    }
}
