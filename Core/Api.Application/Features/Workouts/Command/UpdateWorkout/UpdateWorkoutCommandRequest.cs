using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.UpdateWorkout
{
    public class UpdateWorkoutCommandRequest : IRequest
    {
        public Workouttype WorkoutType { get; set; }
        public string WorkoutDays { get; set; }
        public double WorkoutHours { get; set; }
    }
}
