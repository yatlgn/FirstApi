using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Command.DeleteSeries
{
    public class DeleteSeriesCommandValidator :AbstractValidator<DeleteSeriesCommandRequest>
    {
        public DeleteSeriesCommandValidator()
        {

            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
