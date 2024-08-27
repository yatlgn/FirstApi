using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Parents.Command.UpdateParent
{
    public class UpdateParentCommandValidator : AbstractValidator<UpdateParentCommandRequest>
    {
        public UpdateParentCommandValidator()
        {
            RuleFor(x => x.ParentId)
                .GreaterThan(0).WithMessage("Parent ID must be greater than zero.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name cannot be empty.")
                .MaximumLength(100).WithMessage("Name cannot exceed 100 characters.");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage("Surname cannot be empty.")
                .MaximumLength(100).WithMessage("Surname cannot exceed 100 characters.");

            RuleFor(x => x.Gender)
                .NotNull().WithMessage("Gender is required.");

            RuleFor(x => x.Job)
                .NotEmpty().WithMessage("Job cannot be empty.")
                .MaximumLength(100).WithMessage("Job cannot exceed 100 characters.");

            RuleFor(x => x.PhoneNum)
                .GreaterThan(0).WithMessage("Phone number must be a positive integer.")
                .Must(IsValidPhoneNumber).WithMessage("Phone number must be valid.");

        }

        private bool IsValidPhoneNumber(int arg)
        {
            throw new NotImplementedException();
        }
    }
}
