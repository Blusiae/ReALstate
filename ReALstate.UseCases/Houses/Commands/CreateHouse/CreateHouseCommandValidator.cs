using FluentValidation;
using System.Data;

namespace ReALstate.UseCases.Houses.Commands.CreateHouse
{
    internal class CreateHouseCommandValidator : AbstractValidator<CreateHouseCommand>
    {
        public CreateHouseCommandValidator()
        {
            // replace "a" with "h" in RuleFor
            // replace "a" with "h" in RuleFor
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
