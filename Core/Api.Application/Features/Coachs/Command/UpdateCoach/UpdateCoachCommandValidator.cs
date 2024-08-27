using Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.UpdateCoach
{
    public class UpdateCoachCommandValidator : AbstractValidator<UpdateCoachCommandRequest>
    {
        public UpdateCoachCommandValidator()
        {
            RuleFor(x => x.CoachId)
           .GreaterThan(0).WithMessage("Coach ID must be greater than zero.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname cannot be empty.")
                .MaximumLength(100).WithMessage("Surname cannot exceed 100 characters.");

            RuleFor(x => x.Gender)
                .NotNull().WithMessage("Gender is required.");

            RuleFor(x => x.Branch)
                .NotNull().WithMessage("Branch is required.");

            RuleFor(x => x.Brevet)
                .InclusiveBetween(1, 5).WithMessage("Brevet must be between 1 and 5.");

            RuleFor(x => x.CoachGymnast)
                .NotNull().WithMessage("CoachGymnast collection cannot be null.")
                .Must(x => x.Count > 0).WithMessage("CoachGymnast collection must contain at least one item.");

        }
    }
}
