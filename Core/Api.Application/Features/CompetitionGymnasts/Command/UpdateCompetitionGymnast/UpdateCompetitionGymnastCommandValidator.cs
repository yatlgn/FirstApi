using Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.UpdateCompetitionGymnast
{
    public class UpdateCompetitionGymnastCommandValidator : AbstractValidator<UpdateCompetitionGymnastCommandRequest>
    {
        public UpdateCompetitionGymnastCommandValidator()
        {
            RuleFor(x => x.Id)
             .GreaterThan(0).WithMessage("ID must be greater than zero.");

            RuleFor(x => x.GymnastId)
                .NotEmpty().WithMessage("Gymnast ID cannot be empty.")
                .GreaterThan(0).WithMessage("Gymnast ID must be greater than zero.");

            RuleFor(x => x.CompetitionId)
                .NotEmpty().WithMessage("Competition ID cannot be empty.")
                .GreaterThan(0).WithMessage("Competition ID must be greater than zero.");

        }
    }
}
