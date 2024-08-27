using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Coachs.Command.DeleteCoach
{
    public class DeleteCoachCommandValidator : AbstractValidator<DeleteCoachCommandRequest>
    {
        public DeleteCoachCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
