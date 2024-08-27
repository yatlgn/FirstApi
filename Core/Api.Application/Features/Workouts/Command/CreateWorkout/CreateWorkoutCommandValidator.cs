using Api.Application.Features.Coachs.Command.CreateCoach;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.CreateWorkout
{
    public class CreateWorkoutCommandValidator : AbstractValidator<CreateWorkoutCommandRequest>
    {
        public CreateWorkoutCommandValidator()
        {
            RuleFor(x => x.WorkoutType)
                .NotNull().WithMessage("Workout type is required.")
                .IsInEnum().WithMessage("Invalid workout type.");

            RuleFor(x => x.WorkoutDays)
                .NotEmpty().WithMessage("Workout days are required.")
                .Matches("^(Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|Sunday)(,\\s*(Monday|Tuesday|Wednesday|Thursday|Friday|Saturday|Sunday))*$")
                .WithMessage("Invalid workout days format.");

            RuleFor(x => x.WorkoutHours)
                .GreaterThan(0).WithMessage("Workout hours must be greater than zero.")
                .LessThanOrEqualTo(24).WithMessage("Workout hours cannot exceed 24 hours.");

        }
    }
}
