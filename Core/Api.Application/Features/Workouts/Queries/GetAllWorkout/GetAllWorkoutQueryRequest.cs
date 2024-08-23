﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Queries.GetAllWorkout
{
    public class GetAllWorkoutQueryRequest : IRequest<IList<GetAllWorkoutQueryResponse>>
    {
    }
}