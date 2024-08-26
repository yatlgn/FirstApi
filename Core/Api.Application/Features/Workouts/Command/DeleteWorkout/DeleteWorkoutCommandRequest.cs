using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.DeleteWorkout
{
    public class DeleteWorkoutCommandRequest : IRequest
    {
        public int  Id { get; set; }
    }
}
