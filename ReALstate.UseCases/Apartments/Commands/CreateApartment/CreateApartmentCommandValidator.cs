using FluentValidation;

namespace ReALstate.UseCases.Apartments.Commands.CreateApartment
{
    // CreateApartmentCommandValidator is a class that will be used to validate the CreateApartmentCommand.
    // It inherits from AbstractValidator<CreateApartmentCommand> class, implementing FluentValidation library.
    internal class CreateApartmentCommandValidator : AbstractValidator<CreateApartmentCommand>
    {
        //TODO: set more reasonable values for the fields 
        public CreateApartmentCommandValidator() 
        {
            // RuleFor is a method that is used to set validation rules for the CreateApartmentCommand.
            RuleFor(a => a.Description).NotEmpty();
            RuleFor(a => a.ImageUrl).NotEmpty();
            RuleFor(a => a.MetersSquared).GreaterThan(0);
            RuleFor(a => a.Value).GreaterThan(0);
            RuleFor(a => a.State).NotEmpty();
            RuleFor(a => a.City).NotEmpty();
            RuleFor(a => a.Voivodeship).NotEmpty();
            RuleFor(a => a.Street).NotEmpty();
            RuleFor(dto => dto.PostalCode).Matches(@"^\d{2}-\d{3}$")
            .WithMessage("Postal code should be in XX-XXX format.");
            RuleFor(a => a.Number).NotEmpty();
            RuleFor(a => a.BedroomsCount).GreaterThanOrEqualTo(0);
            RuleFor(a => a.BathroomsCount).GreaterThanOrEqualTo(0);
            RuleFor(a => a.Floor).NotEmpty();


        }
    }
}
