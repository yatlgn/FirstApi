using Api.Application.Features.Coachs.Command.CreateCoach;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Command.CreateCoachGymanst
{
    public class CreateCoachGymnastCommandValidator : AbstractValidator<CreateCoachGymnastCommandRequest>
    {
        public CreateCoachGymnastCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("ID must be greater than zero.");

            RuleFor(x => x.GymnastId)
                .NotEmpty().WithMessage("Gymnast ID cannot be empty.")
                .GreaterThan(0).WithMessage("Gymnast ID must be greater than zero.");

            RuleFor(x => x.CoachId)
                .NotEmpty().WithMessage("Coach ID cannot be empty.")
                .GreaterThan(0).WithMessage("Coach ID must be greater than zero.");

            
        }
    }
}
