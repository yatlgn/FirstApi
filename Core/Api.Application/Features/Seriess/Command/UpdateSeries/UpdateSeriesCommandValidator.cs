using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Command.UpdateSeries
{
    public class UpdateSeriesCommandValidator : AbstractValidator<UpdateSeriesCommandRequest>
    {
        public UpdateSeriesCommandValidator()
        {
            RuleFor(x => x.SeriesId)
    .GreaterThan(0).WithMessage("Series ID must be greater than zero.");

            RuleFor(x => x.TotalPoint)
                .GreaterThanOrEqualTo(0).WithMessage("Total points must be zero or greater.");

            RuleFor(x => x.SeriesReceivingDate)
                .NotEmpty().WithMessage("Series receiving date cannot be empty.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Series receiving date cannot be in the future.");

            RuleFor(x => x.SeriesMinute)
                .GreaterThanOrEqualTo(0).WithMessage("Series minute must be zero or greater.");
        }
    }
}
