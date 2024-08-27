using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Features.Parents.Command.CreateParent;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.GymnastParents.Command.CreateGymnastParent
{
    public class CreateGymnastParentCommandValidator : AbstractValidator<CreateGymnastParentCommandRequest>
    {
        public CreateGymnastParentCommandValidator()
        {
            RuleFor(x => x.Id)
               .GreaterThan(0).WithMessage("ID must be greater than zero.");

            RuleFor(x => x.GymnastId)
                .NotEmpty().WithMessage("Gymnast ID cannot be empty.")
                .GreaterThan(0).WithMessage("Gymnast ID must be greater than zero.");

            RuleFor(x => x.ParentId)
                .NotEmpty().WithMessage("Parent ID cannot be empty.")
                .GreaterThan(0).WithMessage("Parent ID must be greater than zero.");

        }
    }
}
