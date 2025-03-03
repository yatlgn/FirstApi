﻿using System;
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
    public class Workout : EntityBase
    {
        public Workout()
        {

        }
        public Workout(double workoutHours, string workoutDays, Workouttype workoutType)
        {
            WorkoutHours = workoutHours;
            WorkoutDays = workoutDays;
            WorkoutType = workoutType;
        }

        public Workouttype WorkoutType { get; set; }
        public string WorkoutDays { get; set; }
        public double WorkoutHours { get; set; }
    }
}
