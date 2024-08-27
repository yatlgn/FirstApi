using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.UpdateDifficulty
{
    public class UpdateDifficultyCommandValidator : AbstractValidator<UpdateDifficultyCommandRequest>
    {
        public UpdateDifficultyCommandValidator()
        {
            RuleFor(x => x.DifficultyId)
               .GreaterThan(0).WithMessage("Difficulty ID must be greater than zero.");

            RuleFor(x => x.DifficultyName)
                .NotEmpty().WithMessage("Difficulty name cannot be empty.")
                .MaximumLength(100).WithMessage("Difficulty name cannot exceed 100 characters.");

            RuleFor(x => x.DifficultyType)
                .IsInEnum().WithMessage("Invalid difficulty type.");

            RuleFor(x => x.DifficultyPoint)
                .InclusiveBetween(0, 10).WithMessage("Difficulty point must be between 0 and 10.");

        }
    }
}
