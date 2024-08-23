using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Queries.GetAllWorkout
{
    public class GetAllWorkoutQueryResponse
    {
        public Workouttype WorkoutType { get; set; }
        public string WorkoutDays { get; set; }
        public double WorkoutHours { get; set; }
    }
}
