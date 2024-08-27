using Api.Application.Features.Coachs.Command.CreateCoach;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Competitions.Command.CreateCompetition
{
    public class CreateCompetitionCommandValidator : AbstractValidator<CreateCompetitionCommandRequest>
    {
        public CreateCompetitionCommandValidator()
        {
            RuleFor(x => x.CompetitionId)
                .GreaterThan(0).WithMessage("Competition ID must be greater than zero.");

            RuleFor(x => x.CompetitionName)
                .NotEmpty().WithMessage("Competition name is required.")
                .MaximumLength(100).WithMessage("Competition name cannot be longer than 100 characters.");

            RuleFor(x => x.CompetitionHall)
                .NotEmpty().WithMessage("Competition hall is required.")
                .MaximumLength(100).WithMessage("Competition hall cannot be longer than 100 characters.");

            RuleFor(x => x.CompetitionType)
                .IsInEnum().WithMessage("Invalid competition type.");

            RuleFor(x => x.CompetitionDate)
                .NotEmpty().WithMessage("Competition date is required.")
                .GreaterThan(DateTime.Now).WithMessage("Competition date must be in the future.");

            RuleFor(x => x.CompetitionGymnast)
                .NotNull().WithMessage("Competition gymnasts list cannot be null.")
                .Must(gymnasts => gymnasts.Count > 0).WithMessage("At least one gymnast must be associated with the competition.");

        }
    }
}
