﻿using MediatR;

namespace ReALstate.UseCases.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommand : IRequest<int>
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string? Nationality { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string Email { get; set; } = default!;

    }
}