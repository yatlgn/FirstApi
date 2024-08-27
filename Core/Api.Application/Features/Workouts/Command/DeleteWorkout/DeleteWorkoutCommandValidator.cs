using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.DeleteWorkout
{
    public class DeleteWorkoutCommandValidator : AbstractValidator<DeleteWorkoutCommandRequest>
    {
        public DeleteWorkoutCommandValidator()
        {

            RuleFor(x => x.Id)
                .GreaterThan(0);
        }
    }
}
