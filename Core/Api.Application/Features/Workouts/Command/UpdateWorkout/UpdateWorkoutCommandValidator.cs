using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.UpdateWorkout
{
    public class UpdateWorkoutCommandValidator : AbstractValidator<UpdateWorkoutCommandRequest>
    {
        public UpdateWorkoutCommandValidator()
        {
            RuleFor(x => x.WorkoutType)
                .IsInEnum().WithMessage("Invalid workout type.");

            RuleFor(x => x.WorkoutDays)
                .NotEmpty().WithMessage("Workout days cannot be empty.")
                .Matches(@"^[a-zA-Z\s,]+$").WithMessage("Workout days can only contain letters, spaces, and commas.");

            RuleFor(x => x.WorkoutHours)
                .GreaterThan(0).WithMessage("Workout hours must be greater than zero.");
        }
    }
    }

