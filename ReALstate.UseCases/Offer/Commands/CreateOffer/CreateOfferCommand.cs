using MediatR;
using ReALstate.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReALstate.UseCases.Offer.Commands.CreateOffer
{
    public class CreateOfferCommand : IRequest<int>
    {
        public int CustomerId { get; set; }
        public int EstateId { get; set; }
        public double ProposedPrice { get; set; }
    }
}
