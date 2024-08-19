using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Common;

namespace Api.Domain.Entities
{
    public enum Workouttype
    {
        Series,
        Ballet,
        Condition,
        Dance
    }
    public class Workouts : EntityBase
    {
        public Workouttype Workouttype { get; set; }
        public string WorkoutDays { get; set; }
        public double workouthours { get; set; }
    }
}
