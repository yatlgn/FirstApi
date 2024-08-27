using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.GymnastParents.Command.DeleteGymnastParent
{
    public class DeleteGymnastParentCommandValidator : AbstractValidator<DeleteGymnastParentCommandRequest>
    {
        public DeleteGymnastParentCommandValidator()
        {

            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
