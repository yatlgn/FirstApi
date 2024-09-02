using Api.Application.Features.Coachs.Command.UpdateCoach;
using Api.Application.Interfaces.AutoMapper;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Application.Bases;
using Microsoft.AspNetCore.Http;

namespace Api.Application.Features.Workouts.Command.UpdateWorkout
{
    public class UpdateWorkoutCommandHandler :BaseHandler, IRequestHandler<UpdateWorkoutCommandRequest,Unit>
    {
     
        public UpdateWorkoutCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {


        }
        public async Task<Unit> Handle(UpdateWorkoutCommandRequest request, CancellationToken cancellationToken)
        {
            var workout = await unitOfWork.GetReadRepository<Workout>().GetAsync(x => x.WorkoutType == request.WorkoutType && !x.IsDeleted);
            var map = mapper.Map<Workout, UpdateWorkoutCommandRequest>(request);
            
            return Unit.Value;
        }
    }
}
