using Api.Application.Bases;
using Api.Application.Features.Coachs.Command.DeleteCoach;
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

namespace Api.Application.Features.Workouts.Command.DeleteWorkout
{
    public class DeleteWorkoutCommandHandler : BaseHandler, IRequestHandler<DeleteWorkoutCommandRequest, Unit>
    {

   
   
        public DeleteWorkoutCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
    {
           

        }
        public async Task<Unit> Handle(DeleteWorkoutCommandRequest request, CancellationToken cancellationToken)
        {
            var workout = await unitOfWork.GetReadRepository<Workout>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            workout.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Workout>().UpdateAsync(workout);
            await unitOfWork.SaveAsync();
            return Unit.Value;
        }
    }
}
