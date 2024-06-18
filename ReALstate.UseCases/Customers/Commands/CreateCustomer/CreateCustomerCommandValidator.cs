using FluentValidation;

namespace ReALstate.UseCases.Customers.Commands.CreateCustomer
{
    // CreateCustomerCommandValidator class inherits from AbstractValidator class from FluentValidation namespace determining
    // the validation rules for the CreateCustomerCommand class
    public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            //  RuleFor method is used to define the validation rules for the properties of the CreateCustomerCommand class
            RuleFor(customer => customer.FirstName).MinimumLength(2).WithMessage("FirstName should be at least 2 characters long."); 
            
            RuleFor(customer => customer.LastName).MinimumLength(2).WithMessage("LastName should be at least 2 characters long."); 
            
            RuleFor(customer => customer.Email).EmailAddress().WithMessage("Email addres is not valid."); 
            
            RuleFor(customer => customer.PhoneNumber).Matches(@"^\d{9}$")
                .WithMessage("Phone number should be in XXXXXXXXX  format");
            
            RuleFor(customer => customer.Nationality).MinimumLength(3)
                .When(customer => customer.Nationality != null)
                .WithMessage("Nationality is optional or must be at least 3 characters long.");

            
        }
    }
}
