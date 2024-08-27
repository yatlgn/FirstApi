using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.CreateCoach
{
    public class CreateCoachCommandValidator : AbstractValidator<CreateCoachCommandRequest>
    {
        public CreateCoachCommandValidator() { 
        RuleFor(x => x.CoachId)
                .NotEmpty().WithMessage("Coach ID cannot be empty.")
                .GreaterThan(0).WithMessage("Coach ID must be greater than zero.");

        RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name cannot be longer than 50 characters.");

        RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname is required.")
                .MaximumLength(50).WithMessage("Surname cannot be longer than 50 characters.");

        RuleFor(x => x.Gender)
                .NotNull().WithMessage("Gender must be specified.");

        RuleFor(x => x.Branch)
                .NotNull().WithMessage("Branch is required.");

        RuleFor(x => x.Brevet)
                .InclusiveBetween(1, 5).WithMessage("Brevet must be between 1 and 5.");

        RuleFor(x => x.CoachGymnast)
                .NotNull().WithMessage("CoachGymnast list cannot be null.")
                .Must(x => x.Count > 0).WithMessage("Coach must have at least one gymnast associated.");
    }
}
}

