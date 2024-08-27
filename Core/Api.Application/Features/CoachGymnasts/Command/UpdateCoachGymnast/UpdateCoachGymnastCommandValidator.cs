using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Command.UpdateCoachGymnast
{
    public class UpdateCoachGymnastCommandValidator : AbstractValidator<UpdateCoachGymnastCommandRequest>
    {
        public UpdateCoachGymnastCommandValidator()
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
