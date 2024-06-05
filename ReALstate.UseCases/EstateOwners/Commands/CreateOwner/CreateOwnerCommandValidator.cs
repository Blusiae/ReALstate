using FluentValidation;

namespace ReALstate.UseCases.EstateOwners.Commands.CreateOwner
{
    public class CreateOwnerCommandValidator : AbstractValidator<CreateOwnerCommand>
    {
        public CreateOwnerCommandValidator()
        {
            RuleFor(owner => owner.FirstName).MinimumLength(2).WithMessage("FirstName should be at least 2 characters long."); 
            
            RuleFor(owner => owner.LastName).MinimumLength(2).WithMessage("LastName should be at least 2 characters long."); 
            
            RuleFor(owner => owner.Email).EmailAddress().WithMessage("Email addres is not valid."); 
            
            RuleFor(owner => owner.PhoneNumber).Matches(@"^\d{9}$")
                .WithMessage("Phone number should be in XXXXXXXXX  format");
            
            RuleFor(owner => owner.Nationality).MinimumLength(3)
                .When(owner => owner.Nationality != null)
                .WithMessage("Nationality is optional or must be at least 3 characters long.");

            
        }
    }
}
