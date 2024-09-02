using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.CreateCoach;
using Api.Application.Interfaces;
using Api.Application.Interfaces.AutoMapper;
using Api.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.CreateWorkout
{
    public class CreateWorkoutCommandHandler :BaseHandler, IRequestHandler<CreateWorkoutCommandRequest,Unit>
    {
       
        public CreateWorkoutCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
            
        }
        public async Task<Unit> Handle(CreateWorkoutCommandRequest request, CancellationToken cancellationToken)
        {
            Workout workout = new(request.WorkoutHours, request.WorkoutDays, request.WorkoutType);

            await unitOfWork.GetWriteRepository<Workout>().AddAsync(workout);
            var result = await unitOfWork.SaveAsync();

            return Unit.Value;
        }
    }
}
