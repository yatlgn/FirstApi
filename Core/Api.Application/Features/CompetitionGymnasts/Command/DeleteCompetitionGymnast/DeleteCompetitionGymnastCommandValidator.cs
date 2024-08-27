using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CompetitionGymnasts.Command.DeleteCompetitionGymnast
{
    public class DeleteCompetitionGymnastCommandValidator : AbstractValidator<DeleteCompetitionGymnastCommandRequest>
    {
        public DeleteCompetitionGymnastCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
