using FluentValidation;

namespace ReALstate.UseCases.Houses.Commands.CreateHouse
{
    // CreateHouseCommandValidator class inherits from AbstractValidator<CreateHouseCommand> and it is used to validate the CreateHouseCommand object.
    internal class CreateHouseCommandValidator : AbstractValidator<CreateHouseCommand>
    {
        public CreateHouseCommandValidator()
        {
            // RuleFor method is used to define the validation rules for the CreateHouseCommand object.
            RuleFor(h => h.Description).NotEmpty();
            RuleFor(h => h.ImageUrl).NotEmpty();
            RuleFor(h => h.MetersSquared).GreaterThan(0);
            RuleFor(h => h.Value).GreaterThan(0);
            RuleFor(h => h.State).NotEmpty();
            RuleFor(h => h.City).NotEmpty();
            RuleFor(h => h.Voivodeship).NotEmpty();
            RuleFor(h => h.Street).NotEmpty();
            RuleFor(dto => dto.PostalCode).Matches(@"^\d{2}-\d{3}$")
                .WithMessage("Postal code should be in XX-XXX format.");
            RuleFor(h => h.Number).NotEmpty();
            RuleFor(h => h.BedroomsCount).GreaterThanOrEqualTo(0);
            RuleFor(h => h.BathroomsCount).GreaterThanOrEqualTo(0);
            RuleFor(h => h.LandInSquaredMeters).NotEmpty();
        }
       
    }
}
