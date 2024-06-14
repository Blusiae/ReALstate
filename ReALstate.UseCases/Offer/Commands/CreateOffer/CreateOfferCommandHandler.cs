using AutoMapper;
using MediatR;
using ReALstate.Domain.Entities;
using ReALstate.Domain.Exceptions;
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

            if (customer == null)
                throw new NotFoundException(nameof(Customer), request.CustomerId.ToString());

            if (estate == null)
                throw new NotFoundException(nameof(Estate), request.EstateId.ToString());

            var offer = mapper.Map<Domain.Entities.Offer>(request);

            offer.Customer = customer;
            offer.Estate = estate;
 
            int id = await offerRepository.Create(offer);

            return id;
        }
    }
}
