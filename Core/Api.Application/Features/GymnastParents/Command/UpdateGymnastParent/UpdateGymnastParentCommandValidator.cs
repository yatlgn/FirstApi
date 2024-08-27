using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.GymnastParents.Command.UpdateGymnastParent
{
    public class UpdateGymnastParentCommandValidator :AbstractValidator<UpdateGymnastParentCommandRequest>
    {
        public UpdateGymnastParentCommandValidator()
        {
 
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("ID must be greater than zero.");

            RuleFor(x => x.GymnastId)
                .GreaterThan(0).WithMessage("Gymnast ID must be greater than zero.")
                .NotEmpty().WithMessage("Gymnast ID cannot be empty.");

            RuleFor(x => x.ParentId)
                .GreaterThan(0).WithMessage("Parent ID must be greater than zero.")
                .NotEmpty().WithMessage("Parent ID cannot be empty.");

        }
    }
}
