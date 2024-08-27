using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Gymnasts.Command.UpdateGymnast
{
    public class UpdateGymnastCommandValidator : AbstractValidator<UpdateGymnastCommandRequest>
    {
        public UpdateGymnastCommandValidator()
        {
            RuleFor(x => x.GymnastId)
    .GreaterThan(0).WithMessage("Gymnast ID must be greater than zero.");

            // Validation rule for Name
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            // Validation rule for Surname
            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname cannot be empty.")
                .MaximumLength(100).WithMessage("Surname cannot exceed 100 characters.");

            // Validation rule for Birthdate
            RuleFor(x => x.Birthdate)
                .NotEmpty().WithMessage("Birthdate cannot be empty.")
                .LessThan(DateTime.Now).WithMessage("Birthdate must be in the past.");

            // Validation rule for Height
            RuleFor(x => x.Height)
                .GreaterThan(0).WithMessage("Height must be greater than zero.");

            // Validation rule for Weight
            RuleFor(x => x.Weight)
                .GreaterThan(0).WithMessage("Weight must be greater than zero.");

            // Validation rule for BMI
            RuleFor(x => x.BMI)
                .GreaterThan(0).WithMessage("BMI must be greater than zero.");
        }
    }
}
