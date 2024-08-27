using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Features.Competitions.Command.CreateCompetition;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.CreateCompetitionGymnast
{
    public class CreateCompetitionGymnastCommandValidator : AbstractValidator<CreateCompetitionGymnastCommandRequest>
    {
        public CreateCompetitionGymnastCommandValidator()
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
