using Api.Application.Features.Coachs.Command.DeleteCoach;
using Api.Application.Interfaces;
using Api.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.Workouts.Command.DeleteWorkout
{
    public class DeleteWorkoutCommandHandler : IRequestHandler<DeleteWorkoutCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;
        public DeleteWorkoutCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;

        }
        public async Task Handle(DeleteWorkoutCommandRequest request, CancellationToken cancellationToken)
        {
            var workout = await unitOfWork.GetReadRepository<Workout>().GetAsync(x => x.Id == request.Id && !x.IsDeleted);
            workout.IsDeleted = false;

            await unitOfWork.GetWriteRepository<Workout>().UpdateAsync(workout);
            await unitOfWork.SaveAsync();
        }
    }
}
