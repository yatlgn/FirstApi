using Api.Application.Features.Coachs.Command.CreateCoach;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Command.CreateParent
{
    public class CreateParentCommandValidator : AbstractValidator<CreateParentCommandRequest>
    {
        public CreateParentCommandValidator()
        {
            RuleFor(x => x.ParentId)
               .GreaterThan(0).WithMessage("Parent ID must be greater than zero.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name cannot be longer than 50 characters.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname is required.")
                .MaximumLength(50).WithMessage("Surname cannot be longer than 50 characters.");

            RuleFor(x => x.Gender)
                .NotNull().WithMessage("Gender is required.");

            RuleFor(x => x.Job)
                .NotEmpty().WithMessage("Job is required.")
                .MaximumLength(100).WithMessage("Job cannot be longer than 100 characters.");

            RuleFor(x => x.PhoneNum)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\d{10}$").WithMessage("Phone number must be a 10-digit number.");

        }
    }
}
