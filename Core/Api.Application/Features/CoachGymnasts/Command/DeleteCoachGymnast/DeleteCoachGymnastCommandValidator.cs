using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CoachGymnasts.Command.DeleteCoachGymnast
{
    public class DeleteCoachGymnastCommandValidator : AbstractValidator<DeleteCoachGymnastCommandRequest>
    {
        public DeleteCoachGymnastCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
