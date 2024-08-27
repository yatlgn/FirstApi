using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Difficulties.Command.CreateDifficulty
{
    public class CreateDifficultyCommandValidator : AbstractValidator<CreateDifficultyCommandRequest>
    {
        public CreateDifficultyCommandValidator()
        {
            RuleFor(x => x.DifficultyName)
                .NotEmpty().WithMessage("Difficulty name is required.")
                .MaximumLength(50).WithMessage("Difficulty name cannot be longer than 50 characters.");

            RuleFor(x => x.DifficultyType)
                .IsInEnum().WithMessage("Invalid difficulty type.");

            RuleFor(x => x.DifficultyPoint)
                .InclusiveBetween(0, 10).WithMessage("Difficulty point must be between 0 and 10.");

            RuleFor(x => x.DifficultyId)
                .GreaterThan(0).WithMessage("Difficulty ID must be greater than zero.");

        }
    }
}
