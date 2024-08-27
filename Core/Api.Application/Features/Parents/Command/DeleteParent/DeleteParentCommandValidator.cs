using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Command.DeleteParent
{
    public class DeleteParentCommandValidator : AbstractValidator<DeleteParentCommandRequest>
    {
        public DeleteParentCommandValidator()
        {

            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
