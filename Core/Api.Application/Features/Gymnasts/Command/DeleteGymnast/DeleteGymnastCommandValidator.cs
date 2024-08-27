using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Command.DeleteGymnast
{
    public class DeleteGymnastCommandValidator : AbstractValidator<DeleteGymnastCommandRequest>
    {
        public DeleteGymnastCommandValidator()
        {

            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
