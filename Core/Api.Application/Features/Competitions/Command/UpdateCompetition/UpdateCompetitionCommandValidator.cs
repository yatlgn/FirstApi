using Api.Application.Features.CompetitionGymnasts.Command.CreateCompetitionGymnast;
using Api.Application.Features.CompetitionGymnasts.Command.UpdateCompetitionGymnast;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Competitions.Command.UpdateCompetition
{
    public class UpdateCompetitionCommandValidator : AbstractValidator<UpdateCompetitionCommandRequest>
    {
        public UpdateCompetitionCommandValidator()
        {
            RuleFor(x => x.CompetitionId)
                .GreaterThan(0).WithMessage("Competition ID must be greater than zero.");

            RuleFor(x => x.CompetitionName)
                .NotEmpty().WithMessage("Competition name cannot be empty.")
                .MaximumLength(100).WithMessage("Competition name cannot exceed 100 characters.");

            RuleFor(x => x.CompetitionHall)
                .NotEmpty().WithMessage("Competition hall cannot be empty.")
                .MaximumLength(100).WithMessage("Competition hall cannot exceed 100 characters.");

            RuleFor(x => x.CompetitionType)
                .IsInEnum().WithMessage("Invalid competition type.");

            RuleFor(x => x.CompetitionDate)
                .GreaterThan(DateTime.Now).WithMessage("Competition date must be in the future.");

        }
    }
}
