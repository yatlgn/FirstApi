using Api.Application.Features.Coachs.Command.CreateCoach;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Command.CreateGymnast
{
    public class CreateGymnastCommandValidator : AbstractValidator<CreateGymnastCommandRequest>
    {
        public CreateGymnastCommandValidator()
        {
            RuleFor(x => x.GymnastId)
               .GreaterThan(0).WithMessage("Gymnast ID must be greater than zero.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name cannot be longer than 50 characters.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname is required.")
                .MaximumLength(50).WithMessage("Surname cannot be longer than 50 characters.");

            RuleFor(x => x.Birthdate)
                .NotEmpty().WithMessage("Birthdate is required.")
                .LessThan(DateTime.Now).WithMessage("Birthdate must be in the past.");

            RuleFor(x => x.Height)
                .GreaterThan(0).WithMessage("Height must be greater than zero.");

            RuleFor(x => x.Weight)
                .GreaterThan(0).WithMessage("Weight must be greater than zero.");

            RuleFor(x => x.BMI)
                .GreaterThan(0).WithMessage("BMI must be greater than zero.")
                .LessThanOrEqualTo(50).WithMessage("BMI must be 50 or less.");

            RuleFor(x => x.Category)
                .NotNull().WithMessage("Category is required.")
                .IsInEnum().WithMessage("Invalid category.");

            RuleFor(x => x.CompetitionGymnasts)
                .NotNull().WithMessage("Competition gymnasts cannot be null.");

            RuleFor(x => x.CoachGymnasts)
                .NotNull().WithMessage("Coach gymnasts cannot be null.");

            RuleFor(x => x.GymnastParent)
                .NotNull().WithMessage("Gymnast parent cannot be null.");
        }
    }
}
