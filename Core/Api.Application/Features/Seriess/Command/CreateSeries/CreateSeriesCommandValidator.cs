using Api.Application.Features.Coachs.Command.CreateCoach;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Seriess.Command.CreateSeries
{
    public class CreateSeriesCommandValidator : AbstractValidator<CreateSeriesCommandRequest>
    {
        public CreateSeriesCommandValidator()
        {
            RuleFor(x => x.SeriesId)
                .GreaterThan(0).WithMessage("Series ID must be greater than zero.");

            RuleFor(x => x.TotalPoint)
                .InclusiveBetween(0, 100).WithMessage("Total point must be between 0 and 100.");

            RuleFor(x => x.SeriesReceivingDate)
                .NotEmpty().WithMessage("Series receiving date is required.")
                .LessThanOrEqualTo(DateTime.Now).WithMessage("Series receiving date cannot be in the future.");

            RuleFor(x => x.SeriesMinute)
                .GreaterThan(0).WithMessage("Series minute must be greater than zero.");

        }
    }
}
