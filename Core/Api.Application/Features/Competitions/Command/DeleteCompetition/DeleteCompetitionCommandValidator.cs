using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Competitions.Command.DeleteCompetition
{
    public class DeleteCompetitionCommandValidator : AbstractValidator<DeleteCompetitionCommandRequest>
    {
        public DeleteCompetitionCommandValidator()
        {

            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
